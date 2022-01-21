using System.Collections.ObjectModel;
using SMS.Common;
using SMS.Main.Models;
using MediatR;
using Prism.Commands;
using System.Reactive.Disposables;
using PropertyChanged;
using ReactiveUI;
using System;
using System.Reactive.Linq;
using ReactiveUI.Fody.Helpers;


namespace SMS.ViewModels
{

  [AddINotifyPropertyChangedInterface]
  public class MainWindowViewModel : ViewModelBase
  {
    [Reactive]
    public int ContentIndex { get; set; }


    //[Reactive]
    public int SelectedTabIndex { get; set; }


    public DelegateCommand CommandShow => new DelegateCommand(() =>
    {

      System.Diagnostics.Debug.Print("CommandShowDashboard");

    });

    public MainWindowViewModel(IMediator mediator) : base(mediator)
    {



      this.WhenActivated(disposables =>
      {
        ///var model = this.navigationViewModel;

        this.WhenAnyValue(m => m.SelectedTabIndex)
                  .Subscribe(kind =>
                  {
                    switch (kind)
                    {
                      case 0:
                        this.ContentIndex = 1;
                        break;
                      case 1:
                        this.ContentIndex = 1;
                        break;
                      default:
                        break;
                    }
                  });



        this.WhenAnyValue(m => m.ContentIndex)
                           .Select(index => index)
                           .SubscribeOn(RxApp.TaskpoolScheduler)
                           .ObserveOn(RxApp.MainThreadScheduler)
                           .Accept(s =>
                           {
                             switch (s)
                             {
                               case 0:
                                
                                 break;
                               default:
                                 break;
                             }
                           }).DisposeWith(disposables);

      });

    }

    public string Greeting => "Welcome to Avalonia!";

    public ObservableCollection<MenuItem> MenuItems { get; } = new ObservableCollection<MenuItem>();
  }
}
