using Microsoft.Extensions.DependencyInjection;
using Nexus.Desktop.Core;
using Nexus.Desktop.Core.Interfaces;
using Nexus.Desktop.Core.Services;
using Nexus.Shared.Utilities;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Nexus.Desktop.XPlat.Services
{
    public class ShutdownServiceLinux : IShutdownService
    {
        public async Task Shutdown()
        {
            Logger.Debug($"Exiting process ID {Environment.ProcessId}.");
            var casterSocket = ServiceContainer.Instance.GetRequiredService<ICasterSocket>();
            await casterSocket.DisconnectAllViewers();
            Environment.Exit(0);
        }
    }
}
