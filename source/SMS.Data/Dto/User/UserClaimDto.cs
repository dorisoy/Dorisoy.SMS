
namespace SMS.Data.Dto
{
    /// <summary>
    /// 数据对象映射
    /// </summary>
    public class UserClaimDto
    {
        public bool IsFolderCreate { get; set; } = false;
        public bool IsFileUpload { get; set; } = false;
        public bool IsDeleteFileFolder { get; set; } = false;
        public bool IsSharedFileFolder { get; set; } = false;
        public bool IsSendEmail { get; set; } = false;
        public bool IsRenameFile { get; set; } = false;
        public bool IsDownloadFile { get; set; } = false;
        public bool IsCopyFile { get; set; } = false;
        public bool IsCopyFolder { get; set; } = false;
        public bool IsMoveFile { get; set; } = false;
        public bool IsSharedLink { get; set; } = false;
    }
}
