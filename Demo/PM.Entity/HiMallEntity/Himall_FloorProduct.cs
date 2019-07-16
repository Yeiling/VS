using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_FloorProduct
    {
           public Himall_FloorProduct(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:楼层ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long FloorId {get;set;}

           /// <summary>
           /// Desc:楼层标签
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Tab {get;set;}

           /// <summary>
           /// Desc:商品ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ProductId {get;set;}

    }
}
