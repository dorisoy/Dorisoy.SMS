using Prism.Regions;
using SMS.Common;
using MediatR;
namespace SMS.ViewModels
{
  public class DashboardViewModel : ViewModelBase
  {
    private IRegionManager _regionManager;

    public DashboardViewModel(IMediator mediator, IRegionManager regionManager) : base(mediator)
    {
      _regionManager = regionManager;

      Title = "Dashboard - No New Messages";
    }
  }
}
