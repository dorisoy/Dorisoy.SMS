using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace SMS.Data
{
    public interface IUnitOfWork<TContext> where TContext : DbContext
    {
        int Save();
        Task<int> SaveAsync();
        TContext Context { get; }
    }
}
