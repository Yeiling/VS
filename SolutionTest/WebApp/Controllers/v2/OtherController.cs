using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApp.OperModel;

namespace WebApp.Controllers.v2
{
    /// <summary>
    /// 其他
    /// </summary>
    //[ApiController]
    [ApiVersion("2.0")]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/[controller]")]
    public class OtherController : DefaultController
    {
        /// <summary>
        /// 测试数据
        /// </summary>
        private static List<Teacher> userinfoList = new List<Teacher>()
        {
            new Teacher{
                Id=1,
                Name="aa"
            },
            new Teacher{
                Id=2,
                Name="bb"
            },
            new Teacher{
                Id=3,
                Name="cc"
            }
        };


        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        // GET: api/Other
        [HttpGet]
        public IEnumerable<Teacher> Get() => userinfoList;

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="value"></param>
        // POST: api/Other
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT: api/Other/5
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
