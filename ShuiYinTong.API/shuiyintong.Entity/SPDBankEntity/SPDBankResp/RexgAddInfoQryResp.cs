using shuiyintong.Entity.SPDBankEntity.SPDBankResp;

namespace shuiyintong.Entity.SPDBankEntity.SPDResp
{
    /// <summary>
    /// 退汇附加信息查询返回类型
    /// </summary>
    public class RexgAddInfoQryResp: BaseResp
    {       
        /// <summary>
        /// 退汇业务编号
        /// </summary>
        public string withdrawBussId { get; set; }
        /// <summary>
        /// 原往账业务编号
        /// </summary>
        public string payBussId { get; set; }
        /// <summary>
        /// 退汇原因
        /// </summary>
        public string rexgRsn { get; set; }
        /// <summary>
        /// 退汇原因1
        /// </summary>
        public string rexgRsn1 { get; set; }
        /// <summary>
        /// 退汇原因2
        /// </summary>
        public string rexgRsn2 { get; set; }
        /// <summary>
        /// 退汇原因3
        /// </summary>
        public string rexgRsn3 { get; set; }
        /// <summary>
        /// 退汇原因4
        /// </summary>
        public string rexgRsn4 { get; set; }

    }
}
