using MediatR;
using SMS.Data.Resources;
using SMS.Repository;

namespace SMS.MediatR.Queries
{
    public class GetNLogsQuery : IRequest<NLogList>
    {
        public NLogResource NLogResource { get; set; }
    }
}
