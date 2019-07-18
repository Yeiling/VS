using Microsoft.AspNetCore.Mvc;
using PM.Entity.YiiBaidbEntity;
using PM.Service;
using System.Collections.Generic;

namespace PM.WebApi.Controllers
{
    /// <summary>
    /// 用户服务---继承自BaseController
    /// </summary>
    //[Route("api/[controller]/[action]")]
    //[ApiController]
    public class CustomerController : BaseController
    {
        /// <summary>
        /// 获取所有的用户信息
        /// </summary>
        /// <returns></returns>
        // GET: api/Customer
        [HttpGet(Name = "GetAll")]
        public IEnumerable<customers> GetAll()
        {
            return SqlSugarDBContext.GetDbContext().SimpleClientFun(sc =>
            {
                return sc.GetList<customers>();
            });
        }

        /// <summary>
        /// 通过id获取用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Customer/5
        [HttpGet("{id}", Name = "GetById")]
        public customers GetById(int id)
        {
            return SqlSugarDBContext.GetDbContext().SimpleClientFun(sc =>
            {
                return sc.GetById<customers>(id);
            });
        }

        /// <summary>
        /// 查询信息
        /// </summary>
        /// <param name="value"></param>
        // POST: api/Customer
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// 新增用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="id"></param>
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
