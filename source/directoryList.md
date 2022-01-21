
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
