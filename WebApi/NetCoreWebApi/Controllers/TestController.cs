using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using ServiceLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private TestDIOne _test;

        //public TestController(TestDI testDI)
        //{
        //    _test = testDI;
        //}
        //public TestController(IServiceProvider provider)
        //{
        //    _test = provider.GetService<TestDIOne>();
        //}

        private TestDInterface _testDInterface;
        public TestController(TestDInterface testDInterface)
        {
            _testDInterface = testDInterface;
        }


        // GET: api/<TestController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var key = _testDInterface.GetStr("1234567890");
            return new string[] { key };
        }

        // GET api/<TestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
