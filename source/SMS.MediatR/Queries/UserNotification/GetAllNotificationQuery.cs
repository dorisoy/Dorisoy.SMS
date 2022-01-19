using SMS.Data.Resources;
using SMS.Repository;
using MediatR;

namespace SMS.MediatR.Queries
{
    public class GetAllNotificationQuery : IRequest<UserNotificationList>
    {
        public NotificationSource NotificationSource { get; set; }
    }
}
