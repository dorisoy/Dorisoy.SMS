# 关于 Dorisoy.SMS

   基于.net6.0的跨平台WPF学校信息管理系统，现代化UI界面、简单易用的功能让您完全控制管理学生、员工、用户、家长、班级、费用，收入信息、生物识别职工打卡，学生上学/离校信息推送等等， 项目使用MVVM 和Mediator设计模式。

## 支持平台

* `Windows 10+`
* `Linux`
* `macOS`

## 功能

* 学术教学管理
* 人力资源
* 收入管理
* 费用管理
* 课程安排
* 出勤管理
* 档案管理
* 活动管理
* 图书馆
* 校车管理
* 报表
* 系统配置


## 项目结构

    |-- SMS.Common
    |   |-- RegionNames.cs
    |   |-- SMS.Common.csproj
    |   |-- ViewModelBase.cs
    |   |-- Mapping
    |   |   |-- MapperConfig.cs
    |   |   |-- NLogProfile.cs
    |-- SMS.Data
    |   |-- ContextHelper.cs
    |   |-- DefaultEntityMappingExtension.cs
    |   |-- NLogCommandInterceptor.cs
    |   |-- SMS.Data.csproj
    |   |-- StateHelpers.cs
    |   |-- Configuration
    |   |   |-- DatabaseConfiguration.cs
    |   |-- Context
    |   |   |-- SMSContext.cs
    |   |-- Dto
    |   |   |-- LoginAudit
    |   |   |   |-- LoginAuditDto.cs
    |   |   |-- NLog
    |   |   |   |-- NLogDto.cs
    |   |   |-- User
    |   |       |-- AppClaimDto.cs
    |   |       |-- UserAuthDto.cs
    |   |       |-- UserClaimDto.cs
    |   |       |-- UserDto.cs
    |   |       |-- UserInfoDto.cs
    |   |       |-- UserInfoToken.cs
    |   |       |-- UserNotificationDto.cs
    |   |-- Entities
    |   |   |-- BaseEntity.cs
    |   |   |-- LoginAudit.cs
    |   |   |-- NLog.cs
    |   |   |-- ObjectState.cs
    |   |   |-- UserNotification.cs
    |   |-- GenericRespository
    |   |   |-- GenericRespository.cs
    |   |   |-- IGenericRepository.cs
    |   |-- Resources
    |   |   |-- LoginAuditResource.cs
    |   |   |-- NLogResource.cs
    |   |   |-- NotificationSource.cs
    |   |   |-- ResourceParameter.cs
    |   |-- UnitOfWork
    |       |-- IUnitOfWork.cs
    |       |-- UnitOfWork.cs
    |-- SMS.Infrastructure
    |   |-- SMS.Infrastructure.csproj
    |   |-- Helper
    |   |   |-- GenericSpecification.cs
    |   |   |-- IEnumerableExtensions.cs
    |   |   |-- LoginStatus.cs
    |   |   |-- ObjectExtensions.cs
    |   |   |-- ResourceParameters.cs
    |   |   |-- ServiceResponse.cs
    |   |   |-- ThumbnailHelper.cs
    |   |   |-- UTCDateTimeExtension.cs
    |-- SMS.Main
    |   |-- App.axaml
    |   |-- App.axaml.cs
    |   |-- appsettings.json
    |   |-- FluentWindow.cs
    |   |-- Program.cs
    |   |-- SMS.csproj
    |   |-- Core
    |   |   |-- RegionAdapters
    |   |       |-- GridRegionAdapter.cs
    |   |       |-- StackPanelRegionAdapter.cs
    |   |-- Models
    |   |   |-- MenuItem.cs
    |   |-- Modules
    |   |   |-- SampleFooter
    |   |       |-- SampleFooterModule.cs
    |   |       |-- ViewModel
    |   |       |   |-- SampleFooterViewModel.cs
    |   |       |-- Views
    |   |           |-- SampleFooterView.axaml
    |   |           |-- SampleFooterView.axaml.cs
    |   |-- Pages
    |   |   |-- GridViewPage.xaml
    |   |   |-- GridViewPage.xaml.cs
    |   |   |-- OverviewPage.xaml
    |   |   |-- OverviewPage.xaml.cs
    |   |-- Properties
    |   |   |-- launchSettings.json
    |   |-- Styles
    |   |   |-- GeometryConverter.cs
    |   |   |-- MaterialIcon.axaml
    |   |   |-- MaterialIcon.axaml.cs
    |   |   |-- MaterialIconExt.cs
    |   |   |-- SideBar.xaml
    |   |   |-- Styles.xaml
    |   |   |-- Themes
    |   |       |-- DarkTheme.xaml
    |   |       |-- DarkTheme.xaml.cs
    |   |-- ViewModels
    |   |   |-- DashboardViewModel.cs
    |   |   |-- MainTabViewModel.cs
    |   |   |-- MainWindowViewModel.cs
    |   |   |-- NavigationViewModel.cs
    |   |   |-- SettingsViewModel.cs
    |   |-- Views
    |       |-- DashboardView.axaml
    |       |-- DashboardView.axaml.cs
    |       |-- MainTabView.xaml
    |       |-- MainTabView.xaml.cs
    |       |-- MainWindow.axaml
    |       |-- MainWindow.axaml.cs
    |       |-- NavigationView.xaml
    |       |-- NavigationView.xaml.cs
    |       |-- SettingsView.axaml
    |       |-- SettingsView.axaml.cs
    |-- SMS.MediatR
    |   |-- SMS.MediatR.csproj
    |   |-- Commands
    |   |   |-- NLog
    |   |   |   |-- AddLogCommand.cs
    |   |   |-- UserNotification
    |   |       |-- MarkAsReadUserNotificationCommand.cs
    |   |-- Handlers
    |   |   |-- LoginAudit
    |   |   |   |-- GetAllLoginAuditQueryHandler.cs
    |   |   |-- NLog
    |   |   |   |-- AddLogCommandHandler.cs
    |   |   |   |-- GetLogQueryHandler.cs
    |   |   |   |-- GetNLogsQueryHandler.cs
    |   |   |-- UserNotification
    |   |       |-- GetAllNotificationQueryHandler.cs
    |   |       |-- GetNewNotificationsQueryHandler.cs
    |   |       |-- GetNotificationCountQueryHandler.cs
    |   |       |-- MarkAsReadUserNotificationCommandHandler.cs
    |   |-- PipeLineBehavior
    |   |   |-- ValidationBehavior.cs
    |   |-- Queries
    |   |   |-- LoginAudit
    |   |   |   |-- GetAllLoginAuditQuery.cs
    |   |   |-- NLog
    |   |   |   |-- GetLogQuery.cs
    |   |   |   |-- GetNLogsQuery.cs
    |   |   |-- UserNotification
    |   |       |-- GetAllNotificationQuery.cs
    |   |       |-- GetNewNotificationsQuery.cs
    |   |       |-- GetNotificationCountQuery.cs
    |   |-- Validators
    |-- SMS.Modules.Calendar
    |   |-- CalendarModule.cs
    |   |-- SMS.Modules.Calendar.csproj
    |   |-- Assets
    |   |-- ViewModels
    |   |   |-- CalendarViewModel.cs
    |   |-- Views
    |       |-- CalendarView.axaml
    |       |-- CalendarView.axaml.cs
    |-- SMS.Modules.Contacts
    |   |-- ContactsModule.cs
    |   |-- SMS.Modules.Contacts.csproj
    |   |-- ViewModels
    |   |   |-- ContactsViewModel.cs
    |   |-- Views
    |       |-- ContactsView.axaml
    |       |-- ContactsView.axaml.cs
    |-- SMS.Modules.Mail
    |   |-- MailModule.cs
    |   |-- SMS.Modules.Mail.csproj
    |   |-- Models
    |   |   |-- Mail.cs
    |   |-- Services
    |   |   |-- IMailService.cs
    |   |   |-- MailService.cs
    |   |-- ViewModels
    |   |   |-- MailViewModel.cs
    |   |-- Views
    |       |-- MailView.axaml
    |       |-- MailView.axaml.cs
    |-- SMS.Modules.Message
    |   |-- MessageModule.cs
    |   |-- SMS.Modules.Message.csproj
    |   |-- ViewModels
    |   |   |-- MessageViewModel.cs
    |   |-- Views
    |       |-- MessageView.axaml
    |       |-- MessageView.axaml.cs
    |-- SMS.Repository
        |-- SMS.Repository.csproj
        |-- LoginAudit
        |   |-- ILoginAuditRepository.cs
        |   |-- LoginAuditList.cs
        |   |-- LoginAuditRepository.cs
        |-- Mapping
        |   |-- IPropertyMapping.cs
        |   |-- IPropertyMappingService.cs
        |   |-- IQueryableExtensions.cs
        |   |-- ITypeHelperService.cs
        |   |-- PropertyMapping.cs
        |   |-- PropertyMappingService.cs
        |   |-- PropertyMappingValue.cs
        |   |-- TypeHelperService.cs
        |-- NLog
        |   |-- INLogRespository.cs
        |   |-- NLogList.cs
        |   |-- NLogRespository.cs
        |-- UserNotification
            |-- IUserNotificationRepository.cs
            |-- UserNotificationList.cs
            |-- UserNotificationRepository.cs


## 使用的技术和工具


   * <a href="">Avalonia</a> Version:0.10.11
   * <a href="">Avalonia.Desktop</a> Version:0.10.11
   * <a href="">Avalonia.Diagnostics</a> Version:0.10.11
   * <a href="">Avalonia.ReactiveUI</a> Version:0.10.11
   * <a href="">Material.Icons</a> Version:1.0.68
   * <a href="">Prism.Avalonia</a> Version:7.2.0.1430
   * <a href="">Prism.Unity.Avalonia</a> Version:7.2.0.1430
   * <a href="">Microsoft.Extensions.Logging.Console</a> Version:6.0.0
   * <a href="">Prism.Avalonia</a> Version:7.2.0.1430
   * <a href="">Microsoft.Data.SqlClient</a> Version:4.0.1
   * <a href="">Microsoft.EntityFrameworkCore</a> Version:6.0.1
   * <a href="">Microsoft.EntityFrameworkCore.SqlServer</a> Version:6.0.1
   * <a href="">Microsoft.EntityFrameworkCore.Tools</a> Version:6.0.1">
   * <a href="">Microsoft.Extensions.Configuration</a> Version:6.0.0
   * <a href="">Microsoft.Extensions.Configuration.Json</a> Version:6.0.0
   * <a href="">Pomelo.EntityFrameworkCore.MySql</a> Version:6.0.0
   * <a href="">SixLabors.ImageSharp</a> Version:1.0.4
   * <a href="">AutoMapper</a> Version:11.0.0
   * <a href="">AutoMapper.Extensions.Microsoft.DependencyInjection</a> Version:11.0.0
   * <a href="">FluentValidation</a> Version:10.3.6
   * <a href="">FluentValidation.DependencyInjectionExtensions</a> Version:10.3.6
   * <a href="">MediatR</a> Version:10.0.1
   * <a href="">System.Linq.Dynamic.Core</a> Version:1.2.15

   
## 屏幕截图
  
  <img src="https://github.com/dorisoy/Dorisoy.SMS/blob/master/s.png">
