﻿using System.Collections.ObjectModel;
using SMS.Common;
using SMS.Main.Models;
using MediatR;
using Prism.Commands;


namespace SMS.ViewModels
{
  public class MainWindowViewModel : ViewModelBase
  {
    public DelegateCommand CommandShow => new DelegateCommand(() => {

      System.Diagnostics.Debug.Print("CommandShowDashboard");

    });

    public MainWindowViewModel(IMediator mediator) : base(mediator)
    {

 
    }

    public string Greeting => "Welcome to Avalonia!";

    public ObservableCollection<MenuItem> MenuItems { get; } = new ObservableCollection<MenuItem>();
  }
}
