using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SMS.ViewModels;

namespace SMS.Views
{
    public class MainTabView : UserControl
    {
        public MainTabView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);            
        }
    }
}
