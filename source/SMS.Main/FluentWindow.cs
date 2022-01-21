using Avalonia.Styling;
using System;
using System.Collections.Generic;
using SMS.ViewModels;
using Avalonia.Platform;
using Avalonia.Controls.Primitives;
using SMS.Common;
using System.Reactive.Disposables;
using Avalonia;
using Avalonia.Markup.Xaml;
using ReactiveUI;


namespace Avalonia.Controls
{
  public class FluentWindow : BaseWindow<MainWindowViewModel>, IStyleable
  {
    Type IStyleable.StyleKey => typeof(Window);

    public FluentWindow() : base(false)
    {
      ExtendClientAreaToDecorationsHint = true;
      ExtendClientAreaTitleBarHeightHint = -1;

      TransparencyLevelHint = WindowTransparencyLevel.AcrylicBlur;


      //通知
      //this.WhenActivated(disposables =>
      //{
      //  this.BindNotifications()
      //      .DisposeWith(disposables);
      //});


      this.GetObservable(WindowStateProperty)
          .Subscribe(x =>
          {
            PseudoClasses.Set(":maximized", x == WindowState.Maximized);
            PseudoClasses.Set(":fullscreen", x == WindowState.FullScreen);
          });

      this.GetObservable(IsExtendedIntoWindowDecorationsProperty)
          .Subscribe(x =>
          {
            if (!x)
            {
              SystemDecorations = SystemDecorations.Full;
              TransparencyLevelHint = WindowTransparencyLevel.Blur;
            }
          });
    }

    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
      base.OnApplyTemplate(e);
      ExtendClientAreaChromeHints =
          ExtendClientAreaChromeHints.PreferSystemChrome |
          ExtendClientAreaChromeHints.OSXThickTitleBar;
    }
  }
}
