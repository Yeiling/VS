using System;
using System.Linq;
using System.Text;

namespace PM.Entity.YiiBaidbEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class products
    {
           public products(){


           }
           /// <summary>
           /// Desc:产品代码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string productCode {get;set;}

           /// <summary>
           /// Desc:产品名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string productName {get;set;}

           /// <summary>
           /// Desc:产品线
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string productLine {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string productScale {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string productVendor {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string productDescription {get;set;}

           /// <summary>
           /// Desc:库存
           /// Default:
           /// Nullable:False
           /// </summary>           
           public short quantityInStock {get;set;}

           /// <summary>
           /// Desc:价格
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal buyPrice {get;set;}

           /// <summary>
           /// Desc:建议零售价
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal MSRP {get;set;}

    }
}
