using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SMS.Views
{
  public partial class DashboardView : UserControl
  {
    public DashboardView()
    {
      InitializeComponent();
    }

    private void InitializeComponent()
    {
      AvaloniaXamlLoader.Load(this);
    }
  }
}
