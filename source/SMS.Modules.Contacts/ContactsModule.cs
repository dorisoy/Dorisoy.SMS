using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using SMS.Common;
using SMS.Modules.Contacts.Views;

namespace SMS.Modules.Contacts
{
  public class ContactsModule : IModule
  {
    public void OnInitialized(IContainerProvider containerProvider)
    {
      var regionManager = containerProvider.Resolve<IRegionManager>();
      regionManager.RegisterViewWithRegion(RegionNames.RightRegion, typeof(ContactsView));
    }

    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
    }
  }
}