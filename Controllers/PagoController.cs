using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace demomvcgit2.Controllers {
    [Route("[controller]")]
    public class PagoController : Controller {
        private readonly ILogger<PagoController> _logger;

        public PagoController(ILogger<PagoController> logger) {
            _logger = logger;
        }

        public IActionResult Index() { return View(); }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() { return View("Error!"); }
    }
}