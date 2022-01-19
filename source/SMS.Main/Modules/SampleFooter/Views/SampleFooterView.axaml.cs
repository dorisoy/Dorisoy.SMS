using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SMS.Modules.SampleFooter.Views
{
  public partial class SampleFooterView : UserControl
  {
    public SampleFooterView()
    {
      InitializeComponent();
    }

    private void InitializeComponent()
    {
      AvaloniaXamlLoader.Load(this);
    }
  }
}
