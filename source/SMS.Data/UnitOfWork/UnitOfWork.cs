using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using SMS.Data.Dto;

namespace SMS.Data
{
    /// <summary>
    /// 用于表示工作单元
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext
    {
        private readonly TContext _context;
        private readonly ILogger<UnitOfWork<TContext>> _logger;
        private readonly UserInfoToken _userInfoToken;
        public UnitOfWork(
            TContext context,
            ILogger<UnitOfWork<TContext>> logger,
            UserInfoToken userInfoToken)
        {
            _context = context;
            _logger = logger;
            _userInfoToken = userInfoToken;
        }


        /// <summary>
        /// 同步保存（事务）
        /// </summary>
        /// <returns></returns>
        public int Save()
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    //设置修改、删除状态
                    SetModifiedInformation();
                    //保存更改
                    var retValu = _context.SaveChanges();
                    //提交事务
                    transaction.Commit();
                    return retValu;
                }
                catch (Exception e)
                {
                    //异常则回滚
                    transaction.Rollback();
                    _logger.LogError(e, e.Message);
                    return 0;
                }
            }
        }

        /// <summary>
        /// 异步保存（事务）
        /// </summary>
        /// <returns></returns>
        public async Task<int> SaveAsync()
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    //设置修改、删除状态
                    SetModifiedInformation();
                    //保存更改
                    var val = await _context.SaveChangesAsync();
                    //提交事务
                    transaction.Commit();
                    return val;
                }
                catch (Exception e)
                {
                    //异常则回滚
                    transaction.Rollback();
                    _logger.LogError(e, e.Message);
                    return 0;
                }
            }
        }


        public TContext Context => _context;
        public void Dispose()
        {
            _context.Dispose();
        }

        /// <summary>
        /// 设置修改、删除状态
        /// </summary>
        private void SetModifiedInformation()
        {
            foreach (var entry in Context.ChangeTracker.Entries<BaseEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedDate = entry.Entity.CreatedDate == DateTime.MinValue.ToLocalTime() ? DateTime.UtcNow : entry.Entity.CreatedDate;
                    entry.Entity.CreatedBy = entry.Entity.CreatedBy != Guid.Empty ? entry.Entity.CreatedBy : _userInfoToken.Id;
                    entry.Entity.ModifiedBy = entry.Entity.ModifiedBy != Guid.Empty ? entry.Entity.ModifiedBy : _userInfoToken.Id;
                    entry.Entity.ModifiedDate = entry.Entity.ModifiedDate == DateTime.MinValue.ToLocalTime() ? DateTime.UtcNow : entry.Entity.ModifiedDate;
                }
                else if (entry.State == EntityState.Modified)
                {
                    if (entry.Entity.IsDeleted)
                    {
                        entry.Entity.DeletedBy = _userInfoToken.Id;
                        entry.Entity.DeletedDate = DateTime.UtcNow;
                    }
                    else
                    {
                        entry.Entity.ModifiedBy = _userInfoToken.Id;
                        entry.Entity.ModifiedDate = DateTime.UtcNow;
                    }
                }
            }
        }
    }
}
