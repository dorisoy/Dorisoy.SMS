using MediatR;
using System;

namespace SMS.MediatR.Commands
{
    public class MarkAsReadUserNotificationCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
