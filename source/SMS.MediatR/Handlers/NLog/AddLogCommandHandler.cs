using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using SMS.Data;
using SMS.Data.Dto;
using SMS.Infrastructure.Helper;
using SMS.MediatR.Commands;
using SMS.Repository;

namespace SMS.MediatR.Handlers
{
    public class AddLogCommandHandler : IRequestHandler<AddLogCommand, ServiceResponse<NLogDto>>
    {
        private readonly INLogRespository _nLogRespository;
        private readonly IUnitOfWork<SMSContext> _uow;
        public AddLogCommandHandler(INLogRespository nLogRespository,
            IUnitOfWork<SMSContext> uow)
        {
            _nLogRespository = nLogRespository;
            _uow = uow;
        }
        public async Task<ServiceResponse<NLogDto>> Handle(AddLogCommand request, CancellationToken cancellationToken)
        {
            _nLogRespository.Add(new NLog
            {
                Id = Guid.NewGuid(),
                Logged = DateTime.UtcNow,
                Level = "Error",
                Message = request.ErrorMessage,
                Source = "Angular",
                Exception = request.Stack
            });
            await _uow.SaveAsync();
            return ServiceResponse<NLogDto>.ReturnSuccess();
        }
    }
}
