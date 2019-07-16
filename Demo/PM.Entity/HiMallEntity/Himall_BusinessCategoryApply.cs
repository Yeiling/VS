using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_BusinessCategoryApply
    {
           public Himall_BusinessCategoryApply(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:申请日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime ApplyDate {get;set;}

           /// <summary>
           /// Desc:店铺ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:店铺名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ShopName {get;set;}

           /// <summary>
           /// Desc:审核状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int AuditedStatus {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? AuditedDate {get;set;}

    }
}
