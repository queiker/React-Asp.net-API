using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WindController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Data from Controller";
        }
    }
}