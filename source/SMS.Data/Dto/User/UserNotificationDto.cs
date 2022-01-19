using System;

namespace SMS.Data.Dto
{
    /// <summary>
    /// 数据对象映射
    /// </summary>
    public class UserNotificationDto
    {
        public Guid Id { get; set; }
        public Guid? DocumentId { get; set; }
        public Guid? FolderId { get; set; }
        public string FolderName { get; set; }
        public string DocumentName { get; set; }
        public string DocumentThumbnail { get; set; }
        public DateTime CreatedDate { get; set; }
        public string FromUserName { get; set; }
        public Guid FromUserId { get; set; }
        public string Extension { get; set; }
        public bool IsRead { get; set; }
    }
}
