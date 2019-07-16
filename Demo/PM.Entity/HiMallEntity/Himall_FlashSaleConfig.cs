using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_FlashSaleConfig
    {
           public Himall_FlashSaleConfig(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:预热时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Preheat {get;set;}

           /// <summary>
           /// Desc:是否允许正常购买
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte IsNormalPurchase {get;set;}

    }
}
