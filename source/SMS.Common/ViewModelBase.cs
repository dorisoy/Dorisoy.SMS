using Prism.Mvvm;
using Prism.Regions;

using MediatR;
using System.Threading.Tasks;
using SMS.MediatR.Queries;

namespace SMS.Common
{
  public class ViewModelBase : BindableBase, INavigationAware
  {
    private string _title;
    protected readonly IMediator _mediator;

    public string Title
    {
      get => _title;
      set => SetProperty(ref _title, value);
    }

    public ViewModelBase(IMediator mediator)
    {
      _mediator = mediator;
    }


    public bool IsNavigationTarget(NavigationContext navigationContext)
    {
      return OnNavigatingTo(navigationContext);
    }

    public virtual void OnNavigatedFrom(NavigationContext navigationContext)
    {
    }

    public virtual void OnNavigatedTo(NavigationContext navigationContext)
    {
    }

    public virtual bool OnNavigatingTo(NavigationContext navigationContext)
    {
      return true;
    }
  }
}
