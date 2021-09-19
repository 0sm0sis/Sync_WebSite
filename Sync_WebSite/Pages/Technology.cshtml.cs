using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sync_WebSite.Pages
{
    public class TechnologyModel : PageModel
    {
        private readonly ILogger<TechnologyModel> _logger;

        public TechnologyModel(ILogger<TechnologyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
