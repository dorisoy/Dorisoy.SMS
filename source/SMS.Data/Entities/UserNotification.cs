using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Data
{
    public enum NotificationStatusEnum
    {
        InQueue = 0,
        Sent = 1,
        Fail = 2
    }

    /// <summary>
    /// 用于表示系统日志
    /// </summary>
    public class UserNotification
    {
        public Guid Id { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public Guid ToUserId { get; set; } 
        public Guid FromUserId { get; set; }
        public bool IsRead { get; set; } = false;
        public NotificationStatusEnum Status { get; set; } = NotificationStatusEnum.InQueue;
        public string ErrorMsg { get; set; }
    }
}
