using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using SMS.Common;
using SMS.Modules.Calendar.Views;

namespace SMS.Modules.Calendar
{
  public class CalendarModule : IModule
  {
    public void OnInitialized(IContainerProvider containerProvider)
    {
      var regionManager = containerProvider.Resolve<IRegionManager>();
      regionManager.RegisterViewWithRegion(RegionNames.LeftRegion, typeof(CalendarView));
    }

    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
    }
  }
}