using shuiyintong.Entity.SPDBankEntity.SPDBankResp;
using System.Collections.Generic;

namespace shuiyintong.Entity.SPDBankEntity.SPDResp
{
    /// <summary>
    /// 电子回单申请返回类型
    /// </summary>
    public class ElectRecptApplctionResp : BaseResp
    {
        /// <summary>
        /// 笔数
        /// </summary>
        public string totalNum { get; set; }
        /// <summary>
        /// 详情信息数组
        /// </summary>
        public List<eRecptAplInfoItem> eRecptAplInfo { get; set; }
    }

    /// <summary>
    /// 详情信息
    /// </summary>
    public class eRecptAplInfoItem
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        public string applyStatus { get; set; }
        /// <summary>
        /// 返回结果描述
        /// </summary>
        public string resultDesc { get; set; }
        /// <summary>
        /// 表单编号
        /// </summary>
        public string formNo { get; set; }

    }
}
