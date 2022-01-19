using System;

namespace SMS.Data.Dto
{
    /// <summary>
    /// 数据对象映射
    /// </summary>
    public class UserInfoToken
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string ConnectionId { get; set; }
    }
}
