using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_OrderOperationLog
    {
           public Himall_OrderOperationLog(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:订单ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long OrderId {get;set;}

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

    }
}
