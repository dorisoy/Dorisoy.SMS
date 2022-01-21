using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SMS.Common;
using SMS.ViewModels;

namespace SMS.Views
{
    public class MainTabView : BaseControl<MainTabViewModel>
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
