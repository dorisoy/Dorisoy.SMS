using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SMS.Modules.Mail.Views
{
  public partial class MailView : UserControl
  {
    public MailView()
    {
      InitializeComponent();
    }

    private void InitializeComponent()
    {
      AvaloniaXamlLoader.Load(this);
    }
  }
}