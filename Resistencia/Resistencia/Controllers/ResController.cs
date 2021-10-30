using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Resistencia.Application;
using System.Collections.Generic;

namespace Resistencia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResController : ControllerBase
    {
        [HttpPost]
        [Route("Calcular")]

        public string calres(string colorfirst, string colorsecond, string colorthird, string colorfourth)
        {
            var services = new Services();
            var result = services.calres(colorfirst, colorsecond, colorthird, colorfourth);
            return result;
        }
    }
}