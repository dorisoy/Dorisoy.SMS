using SMS.Data.Dto;
using SMS.MediatR.Queries;
using SMS.Repository;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SMS.MediatR.Handlers
{
    public class GetNotificationCountQueryHandler : IRequestHandler<GetNotificationCountQuery, int>
    {
        private readonly IUserNotificationRepository _userNotificationRepository;
        private readonly UserInfoToken _userInfoToken;

        public GetNotificationCountQueryHandler(IUserNotificationRepository userNotificationRepository,
            UserInfoToken userInfoToken)
        {
            _userNotificationRepository = userNotificationRepository;
            _userInfoToken = userInfoToken;
        }

        public Task<int> Handle(GetNotificationCountQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_userNotificationRepository.All.Count(c => c.ToUserId == _userInfoToken.Id && !c.IsRead));
        }
    }
}
