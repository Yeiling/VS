using System.Collections.Generic;

namespace shuiyintong.Entity.SPDBankEntity.SPDResp
{
    /// <summary>
    /// 电子回单申请返回类型
    /// </summary>
    public class ElectRecptApplctionResp
    {
        /// <summary>
        /// 返回信息
        /// </summary>
        public string statusMsg { get; set; }
        /// <summary>
        /// 返回状态码
        /// </summary>
        public string statusCode { get; set; }
        /// <summary>
        /// 交易流水号
        /// </summary>
        public string transNo { get; set; }
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
