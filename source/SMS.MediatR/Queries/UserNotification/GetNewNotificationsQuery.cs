using SMS.Data.Dto;
using MediatR;
using System.Collections.Generic;

namespace SMS.MediatR.Queries
{
    public class GetNewNotificationsQuery : IRequest<List<UserNotificationDto>>
    {
    }
}
