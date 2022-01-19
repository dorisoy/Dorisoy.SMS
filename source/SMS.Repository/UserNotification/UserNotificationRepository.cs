using SMS.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SMS.Data.Dto;
using SMS.Data.Resources;

namespace SMS.Repository
{
    public class UserNotificationRepository : GenericRepository<UserNotification, SMSContext>, IUserNotificationRepository
    {
        private readonly UserInfoToken _userInfoToken;
        private readonly IPropertyMappingService _propertyMappingService;


        public UserNotificationRepository(
            IUnitOfWork<SMSContext> uow,
            UserInfoToken userInfoToken,
            IPropertyMappingService propertyMappingService
            ) : base(uow)
        {
            _userInfoToken = userInfoToken;
            _propertyMappingService = propertyMappingService;
        }

        public Task SaveUserNotification(Guid? folderId, Guid? documentId, List<Guid> users)
        {
            var lstUserNotification = new List<UserNotification>();
            UserNotification UserNotification;
            foreach (var user in users)
            {
                UserNotification = new UserNotification
                {
                    FromUserId = _userInfoToken.Id,
                    ToUserId = user,
                    IsRead = false,
                    Status = NotificationStatusEnum.InQueue,
                    CreatedDate = DateTime.Now
                };
                lstUserNotification.Add(UserNotification);
            }

            if (lstUserNotification.Count > 0)
            {
                AddRange(lstUserNotification);
            }

            return Task.CompletedTask;
        }

        public async Task<UserNotificationList> GetUserNotifications(NotificationSource notificationSource)
        {
            var collectionBeforePaging = All
                          .OrderByDescending(c => c.CreatedDate)
                          .Where(c => c.ToUserId == _userInfoToken.Id);

            collectionBeforePaging = collectionBeforePaging.ApplySort(notificationSource.OrderBy,

               _propertyMappingService.GetPropertyMapping<UserNotificationDto, UserNotification>());


            var userNotifications = new UserNotificationList();
            return await userNotifications.Create(
                collectionBeforePaging,
                notificationSource.Skip,
                notificationSource.PageSize);
        }
    }
}
