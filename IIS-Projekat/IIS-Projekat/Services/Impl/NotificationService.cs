using AutoMapper;
using IIS_Projekat.Configuration;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Notification;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using Microsoft.Extensions.Options;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using System.Net.Mail;
using IIS_Projekat.Models.DTOs.Training.Request;

namespace IIS_Projekat.Services.Impl
{
    public class NotificationService: INotificationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly MailSettings _settings;
        public NotificationService(IUnitOfWork unitOfWork, IMapper mapper, IOptions<MailSettings> settings)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _settings = settings.Value;
        }

        public long CreateNotification(NewNotificationDTO newNotificationDTO)
        {
            var user = _unitOfWork.UserRepository.GetAll().Where(u => u.Email == newNotificationDTO.RecieverEmail).FirstOrDefault();
            if (user == null)
            {
                throw new NotFoundException($"User with given email does not exist.");
            }
            var usersProfile = _unitOfWork.ProfileRepository.GetAll().Where(p => p.UserId == user.Id).FirstOrDefault();
            if (usersProfile == null)
            {
                throw new NotFoundException($"User does not have a profile.");
            }
            var notification = new Notification();
            notification.Reciever = usersProfile;
            notification.Content = newNotificationDTO.Content;
            notification = _unitOfWork.NotificationRepository.Create(notification);
            return notification.Id;
        }

        public PaginationWrapper<PreviewNotificationDTO> GetUsersNotifications(PaginationQuery paginationQuery, string email)
        {
            var user = _unitOfWork.UserRepository.GetAll().Where(u => u.Email == email).ToList().FirstOrDefault();
            if (user == null)
            {
                throw new NotFoundException($"User with given email does not exist.");
            }
            var usersProfile = _unitOfWork.ProfileRepository.GetAll().Where(p => p.UserId == user.Id).ToList().FirstOrDefault();
            if (usersProfile == null)
            {
                throw new NotFoundException($"User does not have a profile.");
            }
            var notifications = _unitOfWork.NotificationRepository.GetAll(n => n.Reciever).Where(n => n.Reciever == usersProfile).ToList();
            return new PaginationWrapper<PreviewNotificationDTO>
            (
                _mapper.Map<List<PreviewNotificationDTO>>(notifications.Skip((paginationQuery.Page - 1) * paginationQuery.PageSize).Take(paginationQuery.PageSize)),
                notifications.Count()
            );
        }

        public long MarkNotificationAsRead(long notificationId)
        {
            var notification = _unitOfWork.NotificationRepository.GetById(notificationId);
            if (notification == null)
            {
                throw new NotFoundException("Notification with given ID does not exist.");
            }
            notification.IsRead = true;
            notification.ModifiedDate = DateTime.Now;
            _unitOfWork.SaveChanges();
            return notification.Id;
        }

        public async Task<bool> SendAsync(MailData mailData, CancellationToken ct = default)
        {
            try
            {
                // Initialize a new instance of the MimeKit.MimeMessage class
                var mail = new MimeMessage();

                #region Sender / Receiver
                // Sender
                mail.From.Add(new MailboxAddress(_settings.DisplayName, mailData.From ?? _settings.From));
                mail.Sender = new MailboxAddress(mailData.DisplayName ?? _settings.DisplayName, mailData.From ?? _settings.From);

                // Receiver
                if(mailData.To != null)
                {
                    mail.To.Add(MailboxAddress.Parse(mailData.To));
                }
                    

                // Set Reply to if specified in mail data
                if (!string.IsNullOrEmpty(mailData.ReplyTo))
                    mail.ReplyTo.Add(new MailboxAddress(mailData.ReplyToName, mailData.ReplyTo));

                #endregion

                #region Content

                // Add Content to Mime Message
                var body = new BodyBuilder();
                mail.Subject = mailData.Subject;
                body.HtmlBody = mailData.Body;
                mail.Body = body.ToMessageBody();

                #endregion

                #region Send Mail

                using var smtp = new MailKit.Net.Smtp.SmtpClient();

                if (_settings.UseSSL)
                {
                    await smtp.ConnectAsync(_settings.Host, _settings.Port, SecureSocketOptions.SslOnConnect, ct);
                }
                else if (_settings.UseStartTls)
                {
                    await smtp.ConnectAsync(_settings.Host, _settings.Port, SecureSocketOptions.StartTls, ct);
                }
                await smtp.AuthenticateAsync(_settings.UserName, _settings.Password, ct);
                await smtp.SendAsync(mail, ct);
                await smtp.DisconnectAsync(true, ct);

                #endregion

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public int GetUnreadNotificationsCount(string email)
        {
            var user = _unitOfWork.UserRepository.GetAll().Where(u => u.Email == email).ToList().FirstOrDefault();
            if (user == null)
            {
                throw new NotFoundException($"User with given email does not exist.");
            }
            var usersProfile = _unitOfWork.ProfileRepository.GetAll().Where(p => p.UserId == user.Id).ToList().FirstOrDefault();
            if (usersProfile == null)
            {
                throw new NotFoundException($"User does not have a profile.");
            }
            var notifications = _unitOfWork.NotificationRepository.GetAll(n => n.Reciever).Where(n => n.Reciever == usersProfile).ToList();
            int unreadCount = 0;
            foreach(var notification in notifications)
            {
                if(notification.IsRead == false) { unreadCount++; }
            }
            return unreadCount;
        }

        public void DeleteNotification(long notificationId)
        {
            var notification = _unitOfWork.NotificationRepository.GetById(notificationId);
            if(notification == null)
            {
                throw new NotFoundException($"Notification does not exist.");
            }
            _unitOfWork.NotificationRepository.Delete(notification);
            _unitOfWork.SaveChanges();
        }
    }
}
