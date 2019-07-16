using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_MobileHomeProduct
    {
           public Himall_MobileHomeProduct(){


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
           /// Desc:终端类型(微信、WAP）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int PlatFormType {get;set;}

           /// <summary>
           /// Desc:顺序
           /// Default:
           /// Nullable:False
           /// </summary>           
           public short Sequence {get;set;}

           /// <summary>
           /// Desc:商品ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ProductId {get;set;}

    }
}
