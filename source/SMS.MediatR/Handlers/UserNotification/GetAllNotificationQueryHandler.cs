using SMS.Data.Dto;
using SMS.MediatR.Queries;
using SMS.Repository;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SMS.MediatR.Handlers
{
    public class GetAllNotificationQueryHandler
        : IRequestHandler<GetAllNotificationQuery, UserNotificationList>
    {
        private readonly IUserNotificationRepository _userNotificationRepository;
        public GetAllNotificationQueryHandler(IUserNotificationRepository userNotificationRepository)
        {
            _userNotificationRepository = userNotificationRepository;
        }

        public async Task<UserNotificationList> Handle(GetAllNotificationQuery request, CancellationToken cancellationToken)
        {
            var entities = await _userNotificationRepository.GetUserNotifications(request.NotificationSource);

            var allUsersIds = entities.Select(c => c.FromUserId).ToList();
            //var allUsers = _userRepository.All.Where(c => allUsersIds.Contains(c.Id)).Select(cs => new UserInfoDto
            //{
            //    Id = cs.Id,
            //    FirstName = cs.FirstName,
            //    LastName = cs.LastName
            //}).ToList();

            //entities.ForEach(entity =>
            //{
            //    var user = allUsers.FirstOrDefault(c => c.Id == entity.FromUserId);
            //    if (user != null)
            //    {
            //        entity.FromUserName = $"{user.FirstName} {user.LastName}";
            //    }
            //});
            return entities;
        }
    }
}
