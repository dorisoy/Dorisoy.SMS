using Avalonia;
using Avalonia.ReactiveUI;

namespace SMS
{
  internal class Program
  {

    public static AppBuilder BuildAvaloniaApp() => AppBuilder
      .Configure<App>()
      .UsePlatformDetect()
      .With(new X11PlatformOptions {
        EnableMultiTouch = false,
        UseDBusMenu = true
      })
      .With(new Win32PlatformOptions {
        EnableMultitouch = true,
        AllowEglInitialization = true
      })
      .UseSkia()
      .UseReactiveUI()
      .LogToTrace();

    public static void Main(string[] args) => BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);



  }
}
