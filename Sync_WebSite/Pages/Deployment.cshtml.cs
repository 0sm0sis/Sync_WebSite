using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sync_WebSite.Pages
{
    public class DeploymentModel : PageModel
    {
        private readonly ILogger<DeploymentModel> _logger;

        public DeploymentModel(ILogger<DeploymentModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
