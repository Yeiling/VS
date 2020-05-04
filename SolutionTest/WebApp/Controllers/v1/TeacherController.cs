using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApp.OperModel;

namespace WebApp.Controllers.v1
{
    /// <summary>
    /// 教师类
    /// </summary>
    //[ApiController]
    [ApiVersion("1.0")]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/[controller]")]
    public class TeacherController : DefaultController
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
            }
        };

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        // GET: api/School
        [HttpGet]
        public IEnumerable<Teacher> Get() => userinfoList;


        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="value"></param>
        // POST: api/School
        [HttpPost]
        public void Post([FromBody] Teacher value) => userinfoList.Add(value);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT: api/School/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Teacher value)
        {
            Delete(id);
            Post(value);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var teacher = userinfoList.Find(t => t.Id == id);
            if (teacher != null)
                userinfoList.Remove(teacher);
        }
    }
}
