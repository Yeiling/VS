using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///用款表
    ///</summary>
    [SugarTable("tb_Yongkuan")]
    public partial class tb_Yongkuan
    {
           public tb_Yongkuan(){


           }
           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:订单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? OrderId {get;set;}

           /// <summary>
           /// Desc:订单编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrderNo {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string status {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? userId {get;set;}

           /// <summary>
           /// Desc:用款编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string YongkuanNo {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? createtime {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? updatetime {get;set;}

           /// <summary>
           /// Desc:准入模型决策结果
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string zrResult {get;set;}

           /// <summary>
           /// Desc:准入生成日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? zrDatetime {get;set;}

           /// <summary>
           /// Desc:开票状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string kpStatus {get;set;}

           /// <summary>
           /// Desc:评估模型结果
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string zrRating {get;set;}

           /// <summary>
           /// Desc:用款额度模型结果
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string zrEdu {get;set;}

           /// <summary>
           /// Desc:人工认定评估模型结果
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string rgRating {get;set;}

           /// <summary>
           /// Desc:自动测算额度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string autoEdu {get;set;}

           /// <summary>
           /// Desc:人工认定授信模型结果
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string rgResult {get;set;}

           /// <summary>
           /// Desc:最终用款额度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? finalEdu {get;set;}

           /// <summary>
           /// Desc:用款起始日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ykStartTime {get;set;}

           /// <summary>
           /// Desc:用款结束日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ykEndTime {get;set;}

           /// <summary>
           /// Desc:放款通知书编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string fkNo {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string cancelReason {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OtherReason {get;set;}

           /// <summary>
           /// Desc:需要系统后台操作 1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string systemflag {get;set;}

           /// <summary>
           /// Desc:当前授信额度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? DqSxEdu {get;set;}

           /// <summary>
           /// Desc:单笔用款额度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? DbYkEdu {get;set;}

           /// <summary>
           /// Desc:提款金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? TkEdu {get;set;}

           /// <summary>
           /// Desc:借款合同编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string JkHtNo {get;set;}

           /// <summary>
           /// Desc:提款日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? tkTime {get;set;}

           /// <summary>
           /// Desc:借款到期日
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? jkEndTime {get;set;}

           /// <summary>
           /// Desc:提款账户户名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string tkAccName {get;set;}

           /// <summary>
           /// Desc:提款账户账号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string tkAccNo {get;set;}

           /// <summary>
           /// Desc:提款账户开户行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string tkBankName {get;set;}

           /// <summary>
           /// Desc:资金用途
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZJyt {get;set;}

           /// <summary>
           /// Desc:实扣金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? SKje {get;set;}

           /// <summary>
           /// Desc:实扣利息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? SKlx {get;set;}

           /// <summary>
           /// Desc:扣款金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? KKje {get;set;}

           /// <summary>
           /// Desc:账户余额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ZHye {get;set;}

           /// <summary>
           /// Desc:扣款时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string KKtime {get;set;}

           /// <summary>
           /// Desc:结清状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string JQstatus {get;set;}

           /// <summary>
           /// Desc:代偿金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DCJe {get;set;}

           /// <summary>
           /// Desc:代偿日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DCRq {get;set;}

           /// <summary>
           /// Desc:偿还金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CHJe {get;set;}

           /// <summary>
           /// Desc:偿还日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CHRq {get;set;}

           /// <summary>
           /// Desc:逾期天数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string YQDays {get;set;}

           /// <summary>
           /// Desc:罚息金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FXJe {get;set;}

           /// <summary>
           /// Desc:用款准入更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? zrupdate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? zryhupdate {get;set;}

           /// <summary>
           /// Desc:报关单决策结果
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bgdzrResult {get;set;}

           /// <summary>
           /// Desc:扣费成功与否
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string kfresult {get;set;}

           /// <summary>
           /// Desc:扣费时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? kftime {get;set;}

           /// <summary>
           /// Desc:扣费金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? kfmoney {get;set;}

           /// <summary>
           /// Desc:自动扣款金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? AutoKoukuan {get;set;}

           /// <summary>
           /// Desc:历史逾期标志 1-历史逾期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string historyYuQi {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string YKDateline {get;set;}

    }
}
