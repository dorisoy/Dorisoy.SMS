using SMS.Data;
using SMS.MediatR.Commands;
using SMS.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace SMS.MediatR.Handlers
{
    public class MarkAsReadUserNotificationCommandHandler : IRequestHandler<MarkAsReadUserNotificationCommand, bool>
    {
        private readonly IUserNotificationRepository _userNotificationRepository;
        private readonly IUnitOfWork<SMSContext> _uow;


        public MarkAsReadUserNotificationCommandHandler(IUserNotificationRepository userNotificationRepository,
            IUnitOfWork<SMSContext> uow)
        {
            _userNotificationRepository = userNotificationRepository;
            _uow = uow;
        }

        public async Task<bool> Handle(MarkAsReadUserNotificationCommand request, CancellationToken cancellationToken)
        {
            var notification = await _userNotificationRepository.FindAsync(request.Id);
            if (notification != null)
            {
                notification.IsRead = true;
                _userNotificationRepository.Update(notification);
                await _uow.SaveAsync();
            }

            return true;
        }
    }
}
