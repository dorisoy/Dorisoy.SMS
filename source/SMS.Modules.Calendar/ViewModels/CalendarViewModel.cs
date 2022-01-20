using SMS.Common;
using MediatR;

namespace SMS.Modules.Calendar.ViewModels
{
  public class CalendarViewModel : ViewModelBase
  {
    public CalendarViewModel(IMediator mediator) : base(mediator)
    {
    }

    public string Greeting => "Welcome to Avalonia!";
  }
}
