using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Massage.Pages
{
    public class AboutMeModel : PageModel
    {
        private readonly ILogger<AboutMeModel> _logger;

        public AboutMeModel(ILogger<AboutMeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
