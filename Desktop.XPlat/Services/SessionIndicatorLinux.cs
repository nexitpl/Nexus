using Avalonia.Controls;
using Avalonia.Threading;
using Nexus.Desktop.Core.Interfaces;
using Nexus.Desktop.XPlat.Views;

namespace Nexus.Desktop.XPlat.Services
{
    public class SessionIndicatorLinux : ISessionIndicator
    {
        public void Show()
        {
            Dispatcher.UIThread.Post(() =>
            {
                var indicatorWindow = new SessionIndicatorWindow();
                indicatorWindow.Show();
            });
        }
    }
}
