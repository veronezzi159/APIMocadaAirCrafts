using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIMocadaAirCrafts.Models;
using System.Text.Json;

namespace APIMocadaAirCrafts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirCraftsController : ControllerBase
    {
        List<AirCraft> airCrafts = new List<AirCraft>
            {
               new AirCraft { Rab = "PT-1234", Capacity = 100, DTRegistry = "2021-01-01", DTLastFlight = "2021-01-01", CnpjCompany = "12345678901234" },
               new AirCraft { Rab = "PT-5678", Capacity = 200, DTRegistry = "2021-01-01", DTLastFlight = "2021-01-01", CnpjCompany = "12345678901234" },
               new AirCraft { Rab = "PT-9876", Capacity = 300, DTRegistry = "2021-01-01", DTLastFlight = "2021-01-01", CnpjCompany = "12345678901234" },
               new AirCraft { Rab = "PT-5432", Capacity = 400, DTRegistry = "2021-01-01", DTLastFlight = "2021-01-01", CnpjCompany = "12345678901234" },
               new AirCraft { Rab = "PT-6789", Capacity = 500, DTRegistry = "2021-01-01", DTLastFlight = "2021-01-01", CnpjCompany = "12345678901234" },
               new AirCraft { Rab = "PT-2468", Capacity = 600, DTRegistry = "2021-01-01", DTLastFlight = "2021-01-01", CnpjCompany = "12345678901234" }

            };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(airCrafts);            
        }

        [HttpGet("{rab}")]
        public IActionResult Get(string rab)
        {
            var airCraft = airCrafts.FirstOrDefault(x => x.Rab == rab);
            if (airCraft == null)
            {
                return NotFound();
            }
            return Ok(airCraft);
        }
            
    }
}
