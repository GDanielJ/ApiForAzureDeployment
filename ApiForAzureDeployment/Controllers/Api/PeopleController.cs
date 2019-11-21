using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiForAzureDeployment.Models;
using ApiForAzureDeployment.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiForAzureDeployment.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private FakeDataService _fakeDataService { get; set; }

        public PeopleController(FakeDataService fakeDataService)
        {
            _fakeDataService = fakeDataService;
        }

        // GET api/people
        [HttpGet]
        public IActionResult GetPerson()
        {
            return Ok(_fakeDataService.GetPeople());
        }


    }
}