using SMS.Common;
using MediatR;

namespace SMS.Modules.Contacts.ViewModels
{
  public class ContactsViewModel : ViewModelBase
  {
    public ContactsViewModel(IMediator mediator) : base(mediator)
    {
    }

    public string Greeting => "Fake Contacts!";
  }
}
