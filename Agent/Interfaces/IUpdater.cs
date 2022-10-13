using System;
using System.Threading.Tasks;

namespace Nexus.Agent.Interfaces
{
    public interface IUpdater
    {
        Task BeginChecking();
        Task CheckForUpdates();
        Task InstallLatestVersion();
    }
}