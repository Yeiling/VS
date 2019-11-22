using System.ComponentModel;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankDeductionReq
{
    /// <summary>
    /// 浦发银行回传平台信息枚举统一定义
    /// </summary>
    public class DeductionEnum
    {
        /// <summary>
        /// 企业规模枚举类型
        /// </summary>
        public enum EnterpriseScaleType
        {
            /// <summary>
            /// 微型企业
            /// </summary>
            [Description("微型")]
            Miniature = 0,
            /// <summary>
            /// 小型企业
            /// </summary>
            [Description("小型")]
            Smal = 10,
            /// <summary>
            /// 中型企业
            /// </summary>
            [Description("中型")]
            Medium = 20,
            /// <summary>
            /// 大型企业
            /// </summary>
            [Description("大型")]
            Large = 30,

        }

        /// <summary>
        /// 推送编码定义
        /// </summary>
        public enum InteractiveCode
        {
            /// <summary>
            /// 失败
            /// </summary>
            [Description("推送失败")]
            Fail = 0,
            /// <summary>
            /// 成功
            /// </summary>
            [Description("推送成功")]
            Success = 1
        }

    }
}
