using Prism.Regions;
using SMS.Common;
using MediatR;

namespace SMS.ViewModels
{
  public class SettingsViewModel : ViewModelBase
  {
    private IRegionManager _regionManager;

    public SettingsViewModel(IMediator mediator, IRegionManager regionManager) : base(mediator)
    {
      _regionManager = regionManager;

      Title = "Settings";
    }
  }
}
