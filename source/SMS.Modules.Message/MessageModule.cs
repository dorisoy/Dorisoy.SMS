using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using SMS.Common;
using SMS.Modules.Message.Views;

namespace SMS.Modules.Message
{
  public class MessageModule : IModule
  {
    public void OnInitialized(IContainerProvider containerProvider)
    {
      containerProvider
        .Resolve<IRegionManager>()
        .RegisterViewWithRegion(RegionNames.RightRegion, typeof(MessageView));
    }

    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
    }
  }
}