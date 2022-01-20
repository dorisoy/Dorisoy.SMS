using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SMS.ViewModels;

namespace SMS.Views
{
    public class NavigationView : UserControl
    {
        public NavigationView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);            
        }
    }
}
