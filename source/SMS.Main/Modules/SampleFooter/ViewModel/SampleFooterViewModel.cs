using SMS.Common;
using MediatR;

namespace SMS.Modules.SampleFooter.ViewModels
{
  public class SampleFooterViewModel : ViewModelBase
  {
    public SampleFooterViewModel(IMediator mediator) : base(mediator)
    {

    }

    public string Message => "Hello footer";
  }
}
