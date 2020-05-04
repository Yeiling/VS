using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodOrderService.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GoodOrderService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[ServiceFilter(typeof(GlobeFilter))]  //单个控制器单独标记,需要在startup容器添加
    [TypeFilter(typeof(GlobeFilter))]  //单个控制器单独标记,需要在startup容器添加
    public class PersonController : ControllerBase
    {
        private static readonly List<string> Persons = new List<string>
        {
            "百年孤独","简爱","静静的多瑙河",""
        };

        private readonly ILogger<PersonController> _logger;
        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Persons;
        }



    }
}
