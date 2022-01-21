using System;
using System.Reactive.Disposables;
using Avalonia;
using Avalonia.ReactiveUI;
using ReactiveUI;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Xaml;
using PropertyChanged;


namespace SMS.Common
{

  [DoNotNotifyAttribute]
  public class BaseControl<TViewModel> : ReactiveUserControl<TViewModel> where TViewModel : class
  {
    //public TViewModel ViewModel => (TViewModel)this.DataContext;

    public BaseControl(bool activate = true)
    {
      //ViewModel = (TViewModel)this.DataContext;

      if (activate)
      {
        this.WhenActivated(disposables =>
        {
          Disposable.Create(() => { }).DisposeWith(disposables);
        });
      }
    }
  }
}