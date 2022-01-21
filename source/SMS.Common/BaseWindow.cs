using System;
using System.Reactive.Disposables;
using Avalonia.ReactiveUI;
using ReactiveUI;
using PropertyChanged;


namespace SMS.Common
{
  [DoNotNotifyAttribute]
  public class BaseWindow<TViewModel> : ReactiveWindow<TViewModel> where TViewModel : class
  {
    //public TViewModel ViewModel => (TViewModel)this.DataContext;
    public BaseWindow(bool activate = true)
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