using MediatR;
using System.Threading;
using System.Threading.Tasks;
using SMS.MediatR.Queries;
using SMS.Repository;

namespace SMS.MediatR.Handlers
{
    public class GetNLogsQueryHandler : IRequestHandler<GetNLogsQuery, NLogList>
    {
        private readonly INLogRespository _nLogRespository;
        public GetNLogsQueryHandler(INLogRespository nLogRespository)
        {
            _nLogRespository = nLogRespository;
        }
        public async Task<NLogList> Handle(GetNLogsQuery request, CancellationToken cancellationToken)
        {
            return await _nLogRespository.GetNLogsAsync(request.NLogResource);
        }
    }
}
