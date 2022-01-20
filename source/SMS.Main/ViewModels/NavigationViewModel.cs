using System.Collections.ObjectModel;
using MediatR;
using Prism.Commands;
using SMS.Common;
using SMS.Main.Models;
using SMS.MediatR.Queries;


namespace SMS.ViewModels
{
  public class NavigationViewModel : ViewModelBase
  {
    public DelegateCommand CommandShow { get; set; }

    public NavigationViewModel(IMediator mediator) : base(mediator)
    {
      CommandShow = new DelegateCommand(async () =>
      {

        var getAllLoginAuditQuery = new GetAllNotificationQuery {

          NotificationSource = new Data.Resources.NotificationSource {

          }
        };



        var result = await _mediator.Send(getAllLoginAuditQuery);

        var paginationMetadata = new
        {
          totalCount = result.TotalCount,
          pageSize = result.PageSize,
          skip = result.Skip,
          totalPages = result.TotalPages
        };

        System.Diagnostics.Debug.Print($"{paginationMetadata.totalCount}");

      });
    }

    public string Greeting => "Welcome to Avalonia!";

    public ObservableCollection<MenuItem> MenuItems { get; } = new ObservableCollection<MenuItem>();
  }
}
