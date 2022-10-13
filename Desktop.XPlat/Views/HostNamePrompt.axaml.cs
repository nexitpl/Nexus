using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Nexus.Desktop.XPlat.ViewModels;
using Nexus.Desktop.XPlat.Views;

namespace Nexus.Desktop.XPlat.Views
{
    public class HostNamePrompt : Window
    {
        public HostNamePrompt()
        {
            Owner = MainWindow.Current;
            InitializeComponent();
        }

        public HostNamePromptViewModel ViewModel => DataContext as HostNamePromptViewModel;

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
