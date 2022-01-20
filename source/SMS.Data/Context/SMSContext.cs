using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SMS.Data
{
  public class SMSContext : DbContext
  {
    public SMSContext(DbContextOptions<SMSContext> options) : base(options)
    {
    }

    //public SMSContext(DbContextOptions options) : base(options)
    //{
    //}

    public DbSet<NLog> NLog { get; set; }
    public DbSet<LoginAudit> LoginAudits { get; set; }
    public DbSet<UserNotification> UserNotifications { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      /*
       System.InvalidOperationException:“No database provider has been configured for this DbContext. A provider can be configured by overriding the 'DbContext.OnConfiguring' method or by using 'AddDbContext' on the application service provider. If 'AddDbContext' is used, then also ensure that your DbContext type accepts a DbContextOptions<TContext> object in its constructor and passes it to the base constructor for DbContext.”
       */
      //读取配置
      var configuration = new ConfigurationBuilder()
          .AddJsonFile("appsettings.json")
          .Build();

      //数据库配置
      var databaseName = configuration["DataAccess:DatabaseName"];
      var connectionString = configuration["DataAccess:ConnectionString"];
      //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Contoso-dev");
      optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 26))).EnableSensitiveDataLogging();
      optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

    }


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
