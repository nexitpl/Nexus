using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nexus.Server.Auth;
using Nexus.Server.Services;
using Nexus.Shared.Models;

namespace Nexus.Server.Pages
{
    [ServiceFilter(typeof(RemoteControlFilterAttribute))]
    public class RemoteControlModel : PageModel
    {
        private readonly IDataService _dataService;
        public RemoteControlModel(IDataService dataService)
        {
            _dataService = dataService;
        }

        public NexusUser NexusUser { get; private set; }
        public void OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                NexusUser = _dataService.GetUserByNameWithOrg(base.User.Identity.Name);
            }
        }
    }
}
