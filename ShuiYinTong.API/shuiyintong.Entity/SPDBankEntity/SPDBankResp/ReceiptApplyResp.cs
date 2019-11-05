namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 电子回单申请返回类型
    /// </summary>
    public class ReceiptApplyResp : BaseResp
    {
        /// <summary>
        /// 回单编号
        /// </summary>
        public string recptNo { get; set; }
        /// <summary>
        /// 电子回单文件名
        /// </summary>
        public string rcpDgFN { get; set; }

    }
}
