using MediatR;
using SMS.Data.Resources;
using SMS.Repository;

namespace SMS.MediatR.Queries
{
    public class GetAllLoginAuditQuery : IRequest<LoginAuditList>
    {
        public LoginAuditResource LoginAuditResource { get; set; }
    }
}
