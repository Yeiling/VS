using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApp.Controllers.v2
{
    /// <summary>
    /// 学校业务
    /// </summary>
    //[ApiController]
    [ApiVersion("2.0")]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/[controller]")]
    public class SchoolController : DefaultController
    {
        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        // GET: api/School
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }    

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="value"></param>
        // POST: api/School
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT: api/School/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
