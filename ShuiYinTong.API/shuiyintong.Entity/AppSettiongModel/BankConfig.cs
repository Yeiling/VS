using System.Collections.Generic;

namespace shuiyintong.Entity.AppSettiongModel
{
    /// <summary>
    /// 银行配置类型
    /// </summary>
    public class BankConfig
    {
        /// <summary>
        /// 控制器和银行映射关系集合
        /// </summary>
        public List<BankControllerItem> BankControllers { get; set; }
        /// <summary>
        /// 浦发银行请求地址配置
        /// </summary>
        public SPDBankConfig SPDBankConfig { get; set; }

    }

    /// <summary>
    /// 银行和控制器对象
    /// </summary>
    public class BankControllerItem
    {
        /// <summary>
        /// 控制器名称
        /// </summary>
        public string Controller { get; set; }
        /// <summary>
        /// 银行名称
        /// </summary>
        public string BankName { get; set; }
    }

}
