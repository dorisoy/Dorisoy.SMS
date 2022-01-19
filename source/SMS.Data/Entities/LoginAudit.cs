using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Data
{
    /// <summary>
    /// 用于表示用户登录审计
    /// </summary>
    public class LoginAudit
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime LoginTime { get; set; }

        [MaxLength(50)]
        public string RemoteIP { get; set; }

        public string Status { get; set; }
        public string Provider { get; set; }

        [MaxLength(50)]
        public string Latitude { get; set; }

        [MaxLength(50)]
        public string Longitude { get; set; }
    }
}
