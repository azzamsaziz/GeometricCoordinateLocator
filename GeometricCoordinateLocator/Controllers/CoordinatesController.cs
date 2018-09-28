using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GeometricCoordinateLocator.Controllers
{
    [Route("api/[controller]")]
    public class CoordinatesController : Controller
    {
        // GET api/coordinates
        [HttpGet]
        public string Get()
        {
            return "API is alive";
        }

        // GET api/coordinates/{x}/{y}
        [HttpGet("{x}/{y}")]
        public string Get(int x, int y)
        {
            return "Get by Coordinate";
        }

        // GET api/coordinates/{row}/{column}
        [HttpGet("{row}/{column}")]
        public string Get(char row, int column)
        {
            return "Get by Triangle";
        }
    }
}