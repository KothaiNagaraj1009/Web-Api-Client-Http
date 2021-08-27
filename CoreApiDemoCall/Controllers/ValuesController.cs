using Microsoft.AspNetCore.Http;
//using MaheApi.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nancy.Json;

namespace CoreApiDemoCall.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public string[] Get()
        {
            
            return new string[] { "Mango", "Apple"};
        }

    }
}
