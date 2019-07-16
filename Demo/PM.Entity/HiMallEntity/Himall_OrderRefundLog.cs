using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///订单售后日志表
    ///</summary>
    public partial class Himall_OrderRefundLog
    {
           public Himall_OrderRefundLog(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:售后编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long RefundId {get;set;}

           /// <summary>
           /// Desc:操作者
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Operator {get;set;}

           /// <summary>
           /// Desc:操作日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime OperateDate {get;set;}

           /// <summary>
           /// Desc:操作内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OperateContent {get;set;}

           /// <summary>
           /// Desc:申请次数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ApplyNumber {get;set;}

           /// <summary>
           /// Desc:退款步聚(枚举:CommonModel.Enum.OrderRefundStep)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public short Step {get;set;}

           /// <summary>
           /// Desc:备注(买家留言/商家留言/商家拒绝原因/平台退款备注)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

    }
}
