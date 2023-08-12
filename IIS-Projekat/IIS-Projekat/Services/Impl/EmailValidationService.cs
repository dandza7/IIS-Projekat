using IIS_Projekat.Models;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;

namespace IIS_Projekat.Services.Impl
{
    public class EmailValidationService : IEmailValidationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly INotificationService _notificationService;

        public EmailValidationService(IUnitOfWork unitOfWork, INotificationService notificationService)
        {
            _unitOfWork = unitOfWork;
            _notificationService = notificationService;
        }

        public long Create(string email)
        {
            var user = _unitOfWork.UserRepository.GetAll(u => u.Profile).Where(u => u.Email == email).FirstOrDefault();
            if(user == null)
            {
                throw new NotFoundException($"User with email: {email} does not exist in the database.");
            }
            if(user.Profile.IsEmailSubscribed)
            {
                throw new BadHttpRequestException($"User with email: {email} is already subscribed.");
            }
            if(user.Profile.Name == null)
            {
                throw new BadHttpRequestException($"Please set up your profile with at least name and surname.");
            }

            Random rnd = new Random();
            long code = rnd.Next(100000, 1000000);
            var newValidation = new EmailValidation
            {
                User = user,
                Code = code
            };
            newValidation = _unitOfWork.EmailValidationRepository.Create(newValidation);
            _unitOfWork.SaveChanges();
            SendVerificationEmail(email, user.Profile.Name, code);
            return newValidation.Id;
        }

        public void Validate(string email, long code)
        {
            var user = _unitOfWork.UserRepository.GetAll(u => u.Profile).Where(u => u.Email == email).FirstOrDefault();
            if (user == null)
            {
                throw new NotFoundException($"User with email: {email} does not exist in the database.");
            }
            var validation = _unitOfWork.EmailValidationRepository.GetAll().Where(ev => ev.User == user).FirstOrDefault();
            if (validation == null)
            {
                throw new NotFoundException($"User did not send a validation request.");
            }
            if(validation.Code != code) {
                throw new BadHttpRequestException($"The code you provided is incorrect.");
            }
            user.Profile.IsEmailSubscribed = true;
            _unitOfWork.EmailValidationRepository.Delete(validation);
            _unitOfWork.ProfileRepository.Update(user.Profile);
            _unitOfWork.SaveChanges();
        }

        public void CancelEmailSubscription(string email)
        {
            var user = _unitOfWork.UserRepository.GetAll(u => u.Profile).Where(u => u.Email == email).FirstOrDefault();
            if (user == null)
            {
                throw new NotFoundException($"User with email: {email} does not exist in the database.");
            }
            if(user.Profile.IsEmailSubscribed == false)
            {
                throw new BadHttpRequestException($"User is not subscribed to email notifications");
            }
            user.Profile.IsEmailSubscribed = false;
            _unitOfWork.ProfileRepository.Update(user.Profile);
            _unitOfWork.SaveChanges();
        }

        private void SendVerificationEmail(string email, string name, long code)
        {
            var newEmail = new MailData
            {
                To = email,
                Subject = $"Your verification code is {code}",
                Body = $"Hello {name},<br/><br/>" +
                    $"Your verification code is {code}.<br/>" +
                    $"Type it inside the application to verify your email." +
                    $"<br/><br/>Regards,<br/>IIS Wellness Center."
            };
            _notificationService.SendAsync(newEmail, default);
        }
    }
}
