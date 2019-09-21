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
            return SqlSugarDBContext.GetDbContext().SimpleClientFun(sc =>
            {
                return sc.GetList<customers>(exp => exp.customerName.Contains(name));
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
        /// 查询通用方法
        /// </summary>
        /// <typeparam name="T">泛型类</typeparam>
        /// <param name="exp">表达式</param>
        /// <returns>对象集合</returns>
        public IEnumerable<T> GetList<T>(Expression<Func<T, bool>> exp) where T : class, new()
        {
            return SqlSugarDBContext.GetDbContext().SimpleClientFun(sc =>
            {
                return sc.GetList(exp);
            });
        }

        /// <summary>
        /// 修改信息
        /// </summary>
        /// <typeparam name="T">泛型类</typeparam>
        /// <param name="model">对象</param>
        /// <returns>是否已经添加</returns>
        [HttpPost]
        public bool Modify<T>(T model) where T : class, new()
        {
            return SqlSugarDBContext.GetDbContext().SimpleClientFun(sc =>
            {
                return sc.Update<T>(model);
            });
        }

        /// <summary>
        /// 根据条件更新特定的列
        /// </summary>
        /// <typeparam name="T">泛型类</typeparam>
        /// <param name="column">列属性</param>
        /// <param name="exp">条件</param>
        /// <returns>是否已经更新</returns>
        public bool Modify<T>(Expression<Func<T, T>> column, Expression<Func<T, bool>> exp) where T : class, new()
        {
            return SqlSugarDBContext.GetDbContext().SimpleClientFun(sc =>
            {
                return sc.Update<T>(column, exp);
            });
        }

        /// <summary>
        /// 新增用户信息
        /// </summary>
        /// <typeparam name="T">泛型类</typeparam>
        /// <param name="model">对象</param>
        /// <returns>是否已经添加</returns>
        [HttpPut("{model}")]
        public bool Add<T>(T model) where T : class, new()
        {
            return SqlSugarDBContext.GetDbContext().SimpleClientFun(sc =>
            {
                return sc.Insert<T>(model);
            });
        }

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="id">主键Id</param>
        /// <returns>是否已经删除</returns>
        [HttpDelete("{id}")]
        public bool Delete(dynamic id)
        {
            return SqlSugarDBContext.GetDbContext().SimpleClientFun(sc =>
            {
                return sc.DeleteById(id);
            });
        }


        /// <summary>
        /// 测试接口---可随时删除
        /// </summary>
        /// <param name="customer"></param>
        [HttpPost]
        public bool TestApi(customers customer) => customer.customerNumber > 100;

    }
}
