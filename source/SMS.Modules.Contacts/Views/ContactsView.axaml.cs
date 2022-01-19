using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SMS.Modules.Contacts.Views
{
  public partial class ContactsView : UserControl
  {
    public ContactsView()
    {
      InitializeComponent();
    }

    private void InitializeComponent()
    {
      AvaloniaXamlLoader.Load(this);
    }
  }
}