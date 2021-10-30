using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Alco.Application;
using System.Collections.Generic;

namespace Alco.Controllers 
{
 [ApiController]
    [Route("api/[controller]")]
    public class AlcoholemiaController : ControllerBase
    {
        [HttpPost]
        [Route("calcular")]

        public string alcocal (int cant, double peso, string drink )
        {
            var services = new Services();
            var result = services.alcocal (cant, peso, drink);
            return result;
        }
    }
}