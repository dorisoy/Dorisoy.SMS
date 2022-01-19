using System.Threading.Tasks;
using SMS.Data;
using SMS.Data.Dto;
using SMS.Data.Resources;

namespace SMS.Repository
{
    public interface INLogRespository : IGenericRepository<NLog>
    {
        Task<NLogList> GetNLogsAsync(NLogResource nLogResource);
    }
}
