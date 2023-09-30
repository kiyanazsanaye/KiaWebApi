using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KiaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActronAirController : ControllerBase
    {

        private readonly ILogger<ActronAirController> _logger;

        public ActronAirController(ILogger<ActronAirController> logger)
        {
            _logger = logger;
        }

        // POST api/<ActronAirController>/List of integers
        [HttpPost()]
        public string Get([FromBody] List<int> lstNumbers)
        {
            var lstNumbersSorted = lstNumbers.OrderByDescending(i => i.ToString()).Where(l => l > 0);//condition of positive numbers
            if (lstNumbersSorted.Count() > 0)
            {
                List<string> lstOutput = lstNumbersSorted.ToList().ConvertAll((e) => (string)e.ToString());
                return string.Join("", lstOutput);
            }
            else
            {
                Response.StatusCode = 400;
                return "Invalid input array [non positive integers or empty array]";
            }
        }
    }
}
