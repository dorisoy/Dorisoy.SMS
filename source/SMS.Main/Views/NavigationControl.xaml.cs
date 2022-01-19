using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SMS.ViewModels;

namespace SMS.Views
{
    public class NavigationControl : UserControl
    {
        public NavigationControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);            
        }
    }
}
