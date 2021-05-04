using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice4.Controllers
{
    [ApiController]
    [Route("/api/info")]
    public class InfoController : ControllerBase
    {
        private readonly IConfiguration _config;

        public InfoController(IConfiguration config)
        {
            _config = config;
        }
        [HttpGet]
        public string getInfo()
        {
            string tmp = _config.GetSection("ProjectTitle").Value;
            string env = _config.GetSection("EnvironmentName").Value;
            string conn = _config.GetConnectionString("DataSource");
            Console.WriteLine(conn);
            return tmp + env;
        }
    }
}
