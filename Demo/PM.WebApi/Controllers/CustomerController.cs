using Microsoft.AspNetCore.Mvc;
using PM.Entity.YiiBaidbEntity;
using PM.Service;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

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
        /// 获取所有的用户信息接口
        /// </summary>
        /// <returns></returns>
        // GET: api/Customer
        [HttpGet(Name = "GetList")]
        public IEnumerable<customers> GetList()
        {
            return SqlSugarDBContext.GetDbContext().SimpleClientFun(sc =>
            {
                return sc.GetList<customers>();
            });
        }

        /// <summary>
        /// 根据名称获取用户信息
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet(Name = "GetListByName")]
        public IEnumerable<customers> GetListByName(string name)
        {
            //表达式树
            Expression<Func<customers, bool>> Exp = exp => exp.customerName.Contains(name);
            return SqlSugarDBContext.GetDbContext().SimpleClientFun(sc =>
            {
                return sc.GetList<customers>(Exp);
            });
        }

        /// <summary>
        /// 通过id获取用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Customer/5
        [HttpGet(Name = "GetEntity")]
        public customers GetEntity(int id)
        {
            return SqlSugarDBContext.GetDbContext().SimpleClientFun(sc =>
            {
                return sc.GetById<customers>(id);
            });
        }

        /// <summary>
        /// 通过id获取用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Customer/5
        [HttpGet(Name = "GetById")]
        public customers GetById(int id)
        {
            return SqlSugarDBContext.GetDbContext().SimpleClientFun(sc =>
            {
                return sc.GetById<customers>(id);
            });
        }
        /// <summary>
        /// 查询/修改信息
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
