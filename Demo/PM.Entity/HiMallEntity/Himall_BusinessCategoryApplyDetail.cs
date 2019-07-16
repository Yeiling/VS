using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_BusinessCategoryApplyDetail
    {
           public Himall_BusinessCategoryApplyDetail(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:分佣比例
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal CommisRate {get;set;}

           /// <summary>
           /// Desc:类目ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long CategoryId {get;set;}

           /// <summary>
           /// Desc:申请Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ApplyId {get;set;}

    }
}
