using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sync_WebSite.Pages
{
    public class BenefitsModel : PageModel
    {
        private readonly ILogger<BenefitsModel> _logger;

        public BenefitsModel(ILogger<BenefitsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
