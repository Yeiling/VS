using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_CollocationSku
    {
           public Himall_CollocationSku(){


           }
           /// <summary>
           /// Desc:ID自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:商品ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ProductId {get;set;}

           /// <summary>
           /// Desc:商品SkuId
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SkuID {get;set;}

           /// <summary>
           /// Desc:组合商品表ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ColloProductId {get;set;}

           /// <summary>
           /// Desc:组合购价格
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal Price {get;set;}

           /// <summary>
           /// Desc:原始价格
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal SkuPirce {get;set;}

    }
}
