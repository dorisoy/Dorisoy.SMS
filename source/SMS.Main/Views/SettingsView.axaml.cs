using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SMS.Common;
using SMS.ViewModels;

namespace SMS.Views
{
  public partial class SettingsView : BaseControl<SettingsViewModel>
  {
    public SettingsView()
    {
      InitializeComponent();
    }

    private void InitializeComponent()
    {
      AvaloniaXamlLoader.Load(this);
    }
  }
}
