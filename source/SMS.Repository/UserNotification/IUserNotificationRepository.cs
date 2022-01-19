using SMS.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SMS.Data.Dto;
using SMS.Data.Resources;

namespace SMS.Repository
{
    public interface IUserNotificationRepository : IGenericRepository<UserNotification>
    {
        Task SaveUserNotification(Guid? folderId, Guid? documentId, List<Guid> users);
        Task<UserNotificationList> GetUserNotifications(NotificationSource notificationSource);
    }
}
