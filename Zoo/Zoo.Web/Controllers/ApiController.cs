using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoo.Web.Services;

namespace Zoo.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private readonly IAnimalsService animalsService;

        public ApiController(IAnimalsService animalsService)
        {
            this.animalsService = animalsService;
        }

        [HttpGet("animals/alivecount")]
        public ActionResult<object> GetAliveAnimalsCount()
        {
            var aliveAnimalsCount = this.animalsService.GetAliveAnimalsCount();

            var response = new
            {
                AliveAnimalscount = aliveAnimalsCount
            };

            return response;
        }
    }
}
