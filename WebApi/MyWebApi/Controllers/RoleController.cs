using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers
{
    /// <summary>
    ///Role API
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : Controller
    {
        private static List<Role> Roles = new List<Role>
            {
                new Role { Id = 1, RoleId = 1001, RoleName = "戏剧演员", Status = 0 },
                new Role { Id = 2, RoleId = 1002, RoleName = "话剧演员", Status = 1 },
                new Role { Id = 3, RoleId = 1003, RoleName = "曲艺演员", Status = 0 },
                new Role { Id = 4, RoleId = 1004, RoleName = "影视演员", Status = 1 },
                new Role { Id = 5, RoleId = 1005, RoleName = "其他演员", Status = 0 }
        };
        /// <summary>
        /// City列表
        /// </summary>
        /// <returns></returns>     
        [HttpGet]
        public ActionResult<IEnumerable<Role>> Get()
        {
            return Roles;
        }
        /// <summary>
        /// Get请求，依据主键获取实体对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<Role> Get(int id)
        {
            return Roles.Find(c => c.Id == id);
        }

        /// <summary>
        /// Post请求
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        /// <summary>
        /// Put请求
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Roles.Remove(Roles.Find(c => c.Id == id));
        }

    }
}