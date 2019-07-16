using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_ModuleProduct
    {
           public Himall_ModuleProduct(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:模块ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ModuleId {get;set;}

           /// <summary>
           /// Desc:商品ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ProductId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long DisplaySequence {get;set;}

    }
}
