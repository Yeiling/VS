using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_BusinessCategory
    {
           public Himall_BusinessCategory(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:分类ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long CategoryId {get;set;}

           /// <summary>
           /// Desc:分佣比例
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal CommisRate {get;set;}

    }
}
