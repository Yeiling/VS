using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers
{
    /// <summary>
    ///City API
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : Controller
    {
        private static List<City> citys = new List<City>
            {
                new City { Id = 1, CityCode = 1001, ParentCodeId = 10, Name = "苏州", Status = 0 },
                new City { Id = 2, CityCode = 1002, ParentCodeId = 10, Name = "上海", Status = 1 },
                new City { Id = 3, CityCode = 1003, ParentCodeId = 10, Name = "南京", Status = 0 },
                new City { Id = 4, CityCode = 1004, ParentCodeId = 10, Name = "广州", Status = 1 },
                new City { Id = 5, CityCode = 1005, ParentCodeId = 10, Name = "北京", Status = 0 },
                new City { Id = 6, CityCode = 1006, ParentCodeId = 10, Name = "深圳", Status = 1 }
        };
        /// <summary>
        /// City列表
        /// </summary>
        /// <returns></returns>     
        [HttpGet]
        public ActionResult<IEnumerable<City>> Get()
        {
            return citys;
        }

        /// <summary>
        /// Get请求，依据主键获取实体对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<City> Get(int id)
        {
            return citys.Find(c => c.Id == id);
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
            citys.Remove(citys.Find(c => c.Id == id));
        }

    }
}