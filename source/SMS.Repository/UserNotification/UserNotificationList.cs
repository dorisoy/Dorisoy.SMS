using SMS.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using SMS.Data.Dto;
using SMS.Data.Resources;

namespace SMS.Repository
{
    public class UserNotificationList : List<UserNotificationDto>
    {
        public int Skip { get; private set; }
        public int TotalPages { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }

        public UserNotificationList()
        {
        }

        public UserNotificationList(List<UserNotificationDto> items, int count, int skip, int pageSize)
        {
            TotalCount = count;
            PageSize = pageSize;
            Skip = skip;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            AddRange(items);
        }

        public async Task<UserNotificationList> CreateAsync(IQueryable<UserNotification> source, int skip, int pageSize)
        {
            var count = await GetCountAsync(source);
            var dtoList = await GetDtosAsync(source, skip, pageSize);
            var dtoPageList = new UserNotificationList(dtoList, count, skip, pageSize);
            return dtoPageList;
        }

        public async Task<int> GetCountAsync(IQueryable<UserNotification> source)
        {
            return await source.AsNoTracking().CountAsync();
        }

        public async Task<List<UserNotificationDto>> GetDtosAsync(IQueryable<UserNotification> source, int skip, int pageSize)
        {
            var entities = await source
                .Skip(skip)
                .Take(pageSize)
                .AsNoTracking()
               .Select(c => new UserNotificationDto
               {
                   Id = c.Id,
                   CreatedDate = c.CreatedDate,
                   FromUserId = c.FromUserId,
                   IsRead = c.IsRead,
               }).ToListAsync();
            return entities;
        }
    }
}
