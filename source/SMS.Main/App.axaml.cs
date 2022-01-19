using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using SMS.Common;
using SMS.Main.Core.RegionAdapters;
using SMS.Modules.Calendar;
using SMS.Modules.Contacts;
using SMS.Modules.Mail;
using SMS.Modules.Message;
using SMS.Modules.SampleFooter;
using SMS.ViewModels;
using SMS.Views;
using SMS.Styles.Themes;

namespace SMS
{
  public class App : PrismApplication
  {
    public override void Initialize()
    {
      AvaloniaXamlLoader.Load(this);

      Styles.Add(new DarkTheme());

      base.Initialize();
    }

    protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
    {
      base.ConfigureModuleCatalog(moduleCatalog);

      moduleCatalog.AddModule<MailModule>();
      moduleCatalog.AddModule<MessageModule>();
      moduleCatalog.AddModule<ContactsModule>();
      moduleCatalog.AddModule<CalendarModule>();
      moduleCatalog.AddModule<SampleFooterModule>();
    }

    protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
    {
      base.ConfigureRegionAdapterMappings(regionAdapterMappings);
      regionAdapterMappings.RegisterMapping(typeof(StackPanel), Container.Resolve<StackPanelRegionAdapter>());
      regionAdapterMappings.RegisterMapping(typeof(Grid), Container.Resolve<GridRegionAdapter>());
    }

    protected override IAvaloniaObject CreateShell()
    {
      return this.Container.Resolve<MainWindow>();
    }

    protected override void OnInitialized()
    {
      // Register Views to Region it will appear in. Don't register them in the ViewModel.
      var regionManager = Container.Resolve<IRegionManager>();
      regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(DashboardView));
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
      // Services
      // .

      // Views - Generic
      containerRegistry.Register<MainWindow>();
      containerRegistry.Register<StackPanelRegionAdapter>();
      containerRegistry.Register<GridRegionAdapter>();

      // Views - Region Navigation
      containerRegistry.RegisterForNavigation<DashboardView, DashboardViewModel>();
      containerRegistry.RegisterForNavigation<SettingsView, SettingsViewModel>();
    }
  }
}