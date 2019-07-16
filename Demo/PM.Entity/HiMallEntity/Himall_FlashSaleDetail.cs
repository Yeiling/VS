using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_FlashSaleDetail
    {
           public Himall_FlashSaleDetail(){


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
           public long ProductId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SkuId {get;set;}

           /// <summary>
           /// Desc:限时购时金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal Price {get;set;}

           /// <summary>
           /// Desc:活动库存
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int TotalCount {get;set;}

           /// <summary>
           /// Desc:对应FlashSale表主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long FlashSaleId {get;set;}

    }
}
