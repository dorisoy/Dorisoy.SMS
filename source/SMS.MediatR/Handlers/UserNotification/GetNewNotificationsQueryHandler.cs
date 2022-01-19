using SMS.Data.Dto;
using SMS.Infrastructure.Helper;
using SMS.MediatR.Queries;
using SMS.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace SMS.MediatR.Handlers
{
    public class GetNewNotificationsQueryHandler : IRequestHandler<GetNewNotificationsQuery, List<UserNotificationDto>>
    {
        private readonly IUserNotificationRepository _userNotificationRepository;
        private readonly UserInfoToken _userInfoToken;

        public GetNewNotificationsQueryHandler(IUserNotificationRepository userNotificationRepository,
            UserInfoToken userInfoToken)
        {
            _userNotificationRepository = userNotificationRepository;
            _userInfoToken = userInfoToken;
        }

        public async Task<List<UserNotificationDto>> Handle(GetNewNotificationsQuery request, CancellationToken cancellationToken)
        {
            var entities = await _userNotificationRepository.All
                          .OrderByDescending(c => c.CreatedDate)
                          .Where(c => c.ToUserId == _userInfoToken.Id && !c.IsRead)
                          .Take(10)
                          .Select(c => new UserNotificationDto
                          {
                              Id = c.Id,
                              CreatedDate = c.CreatedDate,
                              FromUserId = c.FromUserId,
                          }).ToListAsync();

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
