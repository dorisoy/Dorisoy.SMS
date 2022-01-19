using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using SMS.Common;
using SMS.Modules.SampleFooter.ViewModels;
using SMS.Modules.SampleFooter.Views;

namespace SMS.Modules.SampleFooter
{
  public class SampleFooterModule : IModule
  {
    public void OnInitialized(IContainerProvider containerProvider)
    {
      var regionManager = containerProvider.Resolve<IRegionManager>();
      regionManager.RegisterViewWithRegion(RegionNames.FooterRegion, typeof(SampleFooterView));
    }

    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
      // containerRegistry.Register<IMailService, MailService>();
      containerRegistry.RegisterInstance(typeof(SampleFooterViewModel));
    }
  }
}
