using System.Collections.ObjectModel;
using MediatR;
using Prism.Commands;
using SMS.Common;
using SMS.Main.Models;
using SMS.MediatR.Queries;
using System.Reactive.Disposables;
using ReactiveUI;
using System.Reactive.Linq;
using Avalonia.ReactiveUI;
using PropertyChanged;
using System;
using ReactiveUI.Fody.Helpers;


namespace SMS.ViewModels
{

  public class NavigationViewModel : ViewModelBase
  {

    [Reactive]
    public int SelectedTabIndex { get; set; }

    public DelegateCommand CommandShow { get; set; }

    public NavigationViewModel(IMediator mediator) : base(mediator)
    {

      //this.WhenActivated(disposables =>
      //{

      //  this.WhenAnyValue(m => m.SelectedTabIndex)
      //  .Subscribe(kind =>
      //  {
      //    switch (kind)
      //    {
      //      //DashboardView
      //      case 0:
      //        //this.ContentIndex = 0;
      //        break;
      //      //MainTabView
      //      case 1:

      //        break;

      //      default:
      //        //MainTabView
      //        break;
      //    }
      //  }).DisposeWith(disposables);


      //});


      //this.WhenAnyValue(m => m.SelectedTabIndex)
      //        .Subscribe(kind =>
      //        {
      //          switch (kind)
      //          {
      //            //DashboardView
      //            case 0:
      //              //this.ContentIndex = 0;
      //              break;
      //            //MainTabView
      //            case 1:

      //              break;

      //            default:
      //              //MainTabView
      //              break;
      //          }
      //        });





      this.CommandShow = new DelegateCommand(async () =>
      {

        var getAllLoginAuditQuery = new GetAllNotificationQuery {

          NotificationSource = new Data.Resources.NotificationSource {

          }
        };


        var result = await _mediator.Send(getAllLoginAuditQuery);

        var paginationMetadata = new {
          totalCount = result.TotalCount,
          pageSize = result.PageSize,
          skip = result.Skip,
          totalPages = result.TotalPages
        };

        System.Diagnostics.Debug.Print($"{paginationMetadata.totalCount}");

      });
    }


    public ObservableCollection<MenuItem> MenuItems { get; } = new ObservableCollection<MenuItem>();
  }
}
