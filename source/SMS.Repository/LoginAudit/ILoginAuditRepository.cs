using System.Threading.Tasks;
using SMS.Data;
using SMS.Data.Dto;
using SMS.Data.Resources;

namespace SMS.Repository
{
    public interface ILoginAuditRepository : IGenericRepository<LoginAudit>
    {
        Task<LoginAuditList> GetDocumentAuditTrails(LoginAuditResource loginAuditResrouce);
        Task LoginAudit(LoginAuditDto loginAudit);
    }
}
