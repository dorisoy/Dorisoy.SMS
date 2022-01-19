using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace SMS.Data
{
    public class SMSContext : DbContext
    {
        public SMSContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<NLog> NLog { get; set; }
        public DbSet<LoginAudit> LoginAudits { get; set; }
        public DbSet<UserNotification> UserNotifications { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
     
            builder.Entity<NLog>().ToTable("NLogs");
            builder.Entity<LoginAudit>().ToTable("LoginAudits");
            builder.Entity<UserNotification>().ToTable("UserNotifications");


            builder.DefalutMappingValue();
            builder.DefalutDeleteValueFilter();
        }
    }
}
