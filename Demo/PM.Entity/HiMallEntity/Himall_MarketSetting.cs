using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_MarketSetting
    {
           public Himall_MarketSetting(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Id {get;set;}

           /// <summary>
           /// Desc:营销类型ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int TypeId {get;set;}

           /// <summary>
           /// Desc:营销使用价格（/月）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal Price {get;set;}

    }
}
