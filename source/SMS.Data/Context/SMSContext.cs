using System;

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SMS.Data
{
  public class SMSContext : DbContext
  {
    /*
      移数据，在包管理器控制台中，执行命令

      #第一步
      Add-Migration InitialCreate

      #第二步
      Update-Database
     */

    public SMSContext() { }

    public SMSContext(DbContextOptions<SMSContext> options) : base(options) { }


    public DbSet<NLog> NLog { get; set; }
    public DbSet<LoginAudit> LoginAudits { get; set; }
    public DbSet<UserNotification> UserNotifications { get; set; }
    public DbSet<AcademicYear> AcademicYear { get; set; }
    public DbSet<Attendance> Attendance { get; set; }
    public DbSet<Classes> Classes { get; set; }
    public DbSet<Department> Department { get; set; }
    public DbSet<Designation> Designation { get; set; }
    public DbSet<Event> Event { get; set; }
    public DbSet<EventType> EventType { get; set; }
    public DbSet<Expense> Expense { get; set; }
    public DbSet<ExpenseHead> ExpenseHead { get; set; }
    public DbSet<Income> Income { get; set; }
    public DbSet<IncomeHead> IncomeHead { get; set; }
    public DbSet<Library> Library { get; set; }
    public DbSet<Mark> Mark { get; set; }
    public DbSet<Parents> Parents { get; set; }
    public DbSet<PhoneCallLog> PhoneCallLog { get; set; }
    public DbSet<Receptionist> Receptionist { get; set; }
    public DbSet<Role> Role { get; set; }
    public DbSet<Room> Room { get; set; }
    public DbSet<Route> Route { get; set; }
    public DbSet<Schedule> Schedule { get; set; }
    public DbSet<Section> Section { get; set; }
    public DbSet<StaffAttendance> StaffAttendance { get; set; }
    public DbSet<Staff> Staff { get; set; }
    public DbSet<Strand> Strand { get; set; }
    public DbSet<Student> Student { get; set; }
    public DbSet<Subject> Subject { get; set; }
    public DbSet<Teachers> Teachers { get; set; }
    public DbSet<Timetable> Timetable { get; set; }
    public DbSet<UserAccount> UserAccount { get; set; }
    public DbSet<Vehicle> Vehicle { get; set; }
    public DbSet<VehicleRouteL> VehicleRouteL { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);


      builder.Entity<NLog>().ToTable("NLogs");
      builder.Entity<LoginAudit>().ToTable("LoginAudits");
      builder.Entity<UserNotification>().ToTable("UserNotifications");
      builder.Entity<NLog>().ToTable("NLogs");
      builder.Entity<LoginAudit>().ToTable("LoginAudits");
      builder.Entity<UserNotification>().ToTable("UserNotifications");
      builder.Entity<AcademicYear>().ToTable("AcademicYears");
      builder.Entity<Attendance>().ToTable("Attendances");
      builder.Entity<Classes>().ToTable("Classes");
      builder.Entity<Department>().ToTable("Departments");
      builder.Entity<Designation>().ToTable("Designations");
      builder.Entity<Event>().ToTable("Events");
      builder.Entity<EventType>().ToTable("EventTypes");
      builder.Entity<Expense>().ToTable("Expenses");
      builder.Entity<ExpenseHead>().ToTable("ExpenseHeads");
      builder.Entity<Income>().ToTable("Incomes");
      builder.Entity<IncomeHead>().ToTable("IncomeHeads");
      builder.Entity<Library>().ToTable("Libraries");
      builder.Entity<Mark>().ToTable("Marks");
      builder.Entity<Parents>().ToTable("Parents");
      builder.Entity<PhoneCallLog>().ToTable("PhoneCallLogs");
      builder.Entity<Receptionist>().ToTable("Receptionists");
      builder.Entity<Role>().ToTable("Roles");
      builder.Entity<Room>().ToTable("Rooms");
      builder.Entity<Route>().ToTable("Routes");
      builder.Entity<Schedule>().ToTable("Schedules");
      builder.Entity<Section>().ToTable("Sections");
      builder.Entity<StaffAttendance>().ToTable("StaffAttendances");
      builder.Entity<Staff>().ToTable("Staffs");
      builder.Entity<Strand>().ToTable("Strands");
      builder.Entity<Student>().ToTable("Students");
      builder.Entity<Subject>().ToTable("Subjects");
      builder.Entity<Teachers>().ToTable("Teachers");
      builder.Entity<Timetable>().ToTable("Timetables");
      builder.Entity<UserAccount>().ToTable("UserAccounts");
      builder.Entity<Vehicle>().ToTable("Vehicles");
      builder.Entity<VehicleRouteL>().ToTable("VehicleRoutells");


      builder.DefalutMappingValue();
      builder.DefalutDeleteValueFilter();
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      //读取配置
      var configuration = new ConfigurationBuilder()
          .AddJsonFile("appsettings.json")
          .Build();

      //数据库配置
      var databaseName = configuration["DataAccess:DatabaseName"];
      var connectionString = configuration["DataAccess:ConnectionString"];
      optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 26))).EnableSensitiveDataLogging();
      optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

    }

  }
}
