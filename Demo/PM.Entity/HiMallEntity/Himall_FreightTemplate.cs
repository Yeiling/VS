using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_FreightTemplate
    {
           public Himall_FreightTemplate(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:运费模板名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:宝贝发货地
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int SourceAddress {get;set;}

           /// <summary>
           /// Desc:发送时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SendTime {get;set;}

           /// <summary>
           /// Desc:是否商家负责运费
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int IsFree {get;set;}

           /// <summary>
           /// Desc:定价方法(按体积、重量计算）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ValuationMethod {get;set;}

           /// <summary>
           /// Desc:运送类型（物流、快递）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ShippingMethod {get;set;}

           /// <summary>
           /// Desc:店铺ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopID {get;set;}

    }
}
