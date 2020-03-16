using Microsoft.AspNetCore.Mvc;
using Invengo.Library.ResourceService.Models.Test;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Invengo.Library.ResourceService.Controllers
{
    [Route("api/test")]
    public class TestController : ResourceServiceController
    {
        public TestController()
        {
            
        }

        [HttpGet]
        [Route("")]
        public async Task<List<TestModel>> GetAsync()
        {
            return new List<TestModel>
            {
                new TestModel {Name = "John", BirthDate = new DateTime(1942, 11, 18)},
                new TestModel {Name = "Adams", BirthDate = new DateTime(1997, 05, 24)}
            };
        }
    }
}
