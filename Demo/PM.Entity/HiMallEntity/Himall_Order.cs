using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_Order
    {
           public Himall_Order(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:订单状态 [Description("待付款")]WaitPay = 1,[Description("待发货")]WaitDelivery,[Description("待收货")]WaitReceiving,[Description("已关闭")]Close,[Description("已完成")]Finish
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int OrderStatus {get;set;}

           /// <summary>
           /// Desc:订单创建日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime OrderDate {get;set;}

           /// <summary>
           /// Desc:关闭原因
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CloseReason {get;set;}

           /// <summary>
           /// Desc:店铺ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:店铺名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ShopName {get;set;}

           /// <summary>
           /// Desc:商家电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SellerPhone {get;set;}

           /// <summary>
           /// Desc:商家发货地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SellerAddress {get;set;}

           /// <summary>
           /// Desc:商家说明
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SellerRemark {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? SellerRemarkFlag {get;set;}

           /// <summary>
           /// Desc:会员ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long UserId {get;set;}

           /// <summary>
           /// Desc:会员名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserName {get;set;}

           /// <summary>
           /// Desc:会员留言
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UserRemark {get;set;}

           /// <summary>
           /// Desc:收货人
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ShipTo {get;set;}

           /// <summary>
           /// Desc:收货人电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CellPhone {get;set;}

           /// <summary>
           /// Desc:收货人地址省份ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int TopRegionId {get;set;}

           /// <summary>
           /// Desc:收货人区域ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int RegionId {get;set;}

           /// <summary>
           /// Desc:全名的收货地址
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string RegionFullName {get;set;}

           /// <summary>
           /// Desc:收货具体街道信息
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Address {get;set;}

           /// <summary>
           /// Desc:收货地址坐标
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float ReceiveLongitude {get;set;}

           /// <summary>
           /// Desc:收货地址坐标
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float ReceiveLatitude {get;set;}

           /// <summary>
           /// Desc:快递公司
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExpressCompanyName {get;set;}

           /// <summary>
           /// Desc:运费
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal Freight {get;set;}

           /// <summary>
           /// Desc:物流订单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ShipOrderNumber {get;set;}

           /// <summary>
           /// Desc:发货日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ShippingDate {get;set;}

           /// <summary>
           /// Desc:是否打印快递单
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte IsPrinted {get;set;}

           /// <summary>
           /// Desc:付款类型名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PaymentTypeName {get;set;}

           /// <summary>
           /// Desc:付款类型使用 插件名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PaymentTypeGateway {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int PaymentType {get;set;}

           /// <summary>
           /// Desc:支付接口返回的ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GatewayOrderId {get;set;}

           /// <summary>
           /// Desc:付款注释
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PayRemark {get;set;}

           /// <summary>
           /// Desc:付款日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? PayDate {get;set;}

           /// <summary>
           /// Desc:税钱，但是未使用
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal Tax {get;set;}

           /// <summary>
           /// Desc:完成订单日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? FinishDate {get;set;}

           /// <summary>
           /// Desc:商品总金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal ProductTotalAmount {get;set;}

           /// <summary>
           /// Desc:退款金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal RefundTotalAmount {get;set;}

           /// <summary>
           /// Desc:佣金总金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal CommisTotalAmount {get;set;}

           /// <summary>
           /// Desc:退还佣金总金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal RefundCommisAmount {get;set;}

           /// <summary>
           /// Desc:未使用
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ActiveType {get;set;}

           /// <summary>
           /// Desc:来自哪个终端的订单
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Platform {get;set;}

           /// <summary>
           /// Desc:针对该订单的优惠金额（用于优惠券）
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal DiscountAmount {get;set;}

           /// <summary>
           /// Desc:积分优惠金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal IntegralDiscount {get;set;}

           /// <summary>
           /// Desc:订单类型
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OrderType {get;set;}

           /// <summary>
           /// Desc:订单备注(买家留言)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrderRemarks {get;set;}

           /// <summary>
           /// Desc:最后操作时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime LastModifyTime {get;set;}

           /// <summary>
           /// Desc:发货类型(快递配送,到店自提)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int DeliveryType {get;set;}

           /// <summary>
           /// Desc:门店ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long ShopBranchId {get;set;}

           /// <summary>
           /// Desc:提货码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PickupCode {get;set;}

           /// <summary>
           /// Desc:订单实付金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal TotalAmount {get;set;}

           /// <summary>
           /// Desc:订单实收金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal ActualPayAmount {get;set;}

           /// <summary>
           /// Desc:满额减金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal FullDiscount {get;set;}

           /// <summary>
           /// Desc:预付款支付金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal CapitalAmount {get;set;}

           /// <summary>
           /// Desc:使用的优惠券Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long CouponId {get;set;}

           /// <summary>
           /// Desc:达达取消发单原因
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CancelReason {get;set;}

           /// <summary>
           /// Desc:达达状态
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int DadaStatus {get;set;}

    }
}
