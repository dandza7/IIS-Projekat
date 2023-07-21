using IIS_Projekat.Models.DTOs.Notification;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Patient;
using IIS_Projekat.Models.DTOs.Training.Plan;
using IIS_Projekat.Models.DTOs.Training.Session;
using IIS_Projekat.Services;
using IIS_Projekat.Services.Impl;
using IIS_Projekat.SupportClasses.Extensions;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IIS_Projekat.Controllers
{
    [ApiController]
    [Route("api/notification")]
    public class NotificationController: ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        /// <summary>
        /// [Trainer, Doctors, Customer] Gets users notifications
        /// </summary>
        /// <remarks>
        /// Pagination constraints (Everything is case insenstive):
        /// <br/>  > Page and PageSize must be greater than 0 (0 if you want all items at once)
        /// </remarks>
        /// <response code="200">If notifications were retrieved successfully</response>
        /// <response code="404">If user was not found</response>
        /// <response code="404">If user's profile was not found</response>
        [HttpPost("notifications", Name = "GetUsersNotifications")]
        [Authorize(Roles = $"{Roles.Trainer}, {Roles.Doctors}, {Roles.Customer}")]
        public ActionResult<PreviewNotificationDTO> GetUsersNotifications([FromBody] PaginationQuery paginationQuery)
        {
            return Ok(_notificationService.GetUsersNotifications(paginationQuery, User.GetEmail()));
        }

        /// <summary>
        /// [Doctors, Customer, Trainer] Marks notification as read
        /// </summary>
        /// <response code="200">If notification was updated successfully</response>
        /// <response code="404">If notification was not found</response>
        [HttpPut("update/{notificationId}", Name = "UpdateNotification")]
        [Authorize(Roles = $"{Roles.Doctors}, {Roles.Trainer}, {Roles.Customer}")]
        public ActionResult<long> MarkNotificationAsRead(long notificationId)
        {
            return Ok(_notificationService.MarkNotificationAsRead(notificationId));
        }

        /// <summary>
        /// [Doctors, Customer, Trainer] Gets Count Of Users Unread Notifications
        /// </summary>
        /// <response code="200">If count was retrieved successfully</response>
        /// <response code="404">If user was not found</response>
        /// <response code="404">If user's profile was not found</response>
        [HttpGet("notifications/unread-count", Name = "GetUnreadNotificationsCount")]
        [Authorize(Roles = $"{Roles.Doctors}, {Roles.Customer}, {Roles.Trainer}")]
        public ActionResult<int> GetUnreadNotificationsCount()
        {
            return Ok(_notificationService.GetUnreadNotificationsCount(User.GetEmail()));
        }

        /// <summary>
        /// [Trainer, Doctors, Customer] Deletes Notification
        /// </summary>
        /// <response code="200">If notification is successfully deleted</response>
        /// <response code="404">If notification does not exist in the database</response>
        [HttpDelete("delete/{id}", Name = "DeleteNotification")]
        [Authorize(Roles = $"{Roles.Trainer}, {Roles.Doctors}, {Roles.Customer}")]
        public ActionResult DeleteExercise(long id)
        {
            _notificationService.DeleteNotification(id);
            return Ok();
        }
    }
}
