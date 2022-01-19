using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using SMS.Common;
using SMS.Modules.Mail.Services;
using SMS.Modules.Mail.ViewModels;
using SMS.Modules.Mail.Views;

namespace SMS.Modules.Mail
{
  public class MailModule : IModule
  {
    public void OnInitialized(IContainerProvider containerProvider)
    {
      var regionManager = containerProvider.Resolve<IRegionManager>();
      regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(MailView));
    }

    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
      containerRegistry.Register<IMailService, MailService>();
      containerRegistry.RegisterInstance(typeof(MailViewModel));
    }
  }
}