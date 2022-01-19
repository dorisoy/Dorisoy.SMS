using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SMS.ViewModels;


namespace SMS.Pages
{
    public class GridViewPage : UserControl
    {
        public GridViewPage()
        {
            this.InitializeComponent();

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
