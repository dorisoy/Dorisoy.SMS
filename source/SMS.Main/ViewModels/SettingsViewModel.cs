using Prism.Regions;
using SMS.Common;

namespace SMS.ViewModels
{
  public class SettingsViewModel : ViewModelBase
  {
    private IRegionManager _regionManager;

    public SettingsViewModel(IRegionManager regionManager)
    {
      _regionManager = regionManager;

      Title = "Settings";
    }
  }
}
