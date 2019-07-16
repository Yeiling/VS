using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_OrderItem
    {
           public Himall_OrderItem(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:订单ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long OrderId {get;set;}

           /// <summary>
           /// Desc:店铺ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:商品ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ProductId {get;set;}

           /// <summary>
           /// Desc:SKUId
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SkuId {get;set;}

           /// <summary>
           /// Desc:SKU表SKU字段
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SKU {get;set;}

           /// <summary>
           /// Desc:购买数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Quantity {get;set;}

           /// <summary>
           /// Desc:退货数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ReturnQuantity {get;set;}

           /// <summary>
           /// Desc:成本价
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal CostPrice {get;set;}

           /// <summary>
           /// Desc:销售价
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal SalePrice {get;set;}

           /// <summary>
           /// Desc:优惠金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal DiscountAmount {get;set;}

           /// <summary>
           /// Desc:实际应付金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal RealTotalPrice {get;set;}

           /// <summary>
           /// Desc:退款价格
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal RefundPrice {get;set;}

           /// <summary>
           /// Desc:商品名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ProductName {get;set;}

           /// <summary>
           /// Desc:SKU颜色
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Color {get;set;}

           /// <summary>
           /// Desc:SKU尺寸
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Size {get;set;}

           /// <summary>
           /// Desc:SKU版本
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Version {get;set;}

           /// <summary>
           /// Desc:缩略图
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ThumbnailsUrl {get;set;}

           /// <summary>
           /// Desc:分佣比例
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal CommisRate {get;set;}

           /// <summary>
           /// Desc:可退金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? EnabledRefundAmount {get;set;}

           /// <summary>
           /// Desc:是否为限时购商品
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public byte IsLimitBuy {get;set;}

           /// <summary>
           /// Desc:可退积分抵扣金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? EnabledRefundIntegral {get;set;}

           /// <summary>
           /// Desc:优惠券抵扣金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal CouponDiscount {get;set;}

           /// <summary>
           /// Desc:满额减平摊到订单项的金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal FullDiscount {get;set;}

           /// <summary>
           /// Desc:核销码生效时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? EffectiveDate {get;set;}

           /// <summary>
           /// Desc:限时购活动ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long FlashSaleId {get;set;}

    }
}
