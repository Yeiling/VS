using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_OrderRefund
    {
           public Himall_OrderRefund(){


           }
           /// <summary>
           /// Desc:
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
           /// Desc:订单详情ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long OrderItemId {get;set;}

           /// <summary>
           /// Desc:核销码ID集合(本次申请哪些核销码退款)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VerificationCodeIds {get;set;}

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
           /// Desc:用户ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long UserId {get;set;}

           /// <summary>
           /// Desc:申请内容
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Applicant {get;set;}

           /// <summary>
           /// Desc:联系人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ContactPerson {get;set;}

           /// <summary>
           /// Desc:联系电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ContactCellPhone {get;set;}

           /// <summary>
           /// Desc:退款金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RefundAccount {get;set;}

           /// <summary>
           /// Desc:申请时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime ApplyDate {get;set;}

           /// <summary>
           /// Desc:金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal Amount {get;set;}

           /// <summary>
           /// Desc:退款原因
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Reason {get;set;}

           /// <summary>
           /// Desc:退款详情
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ReasonDetail {get;set;}

           /// <summary>
           /// Desc:商家审核状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int SellerAuditStatus {get;set;}

           /// <summary>
           /// Desc:商家审核时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime SellerAuditDate {get;set;}

           /// <summary>
           /// Desc:商家注释
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SellerRemark {get;set;}

           /// <summary>
           /// Desc:平台审核状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ManagerConfirmStatus {get;set;}

           /// <summary>
           /// Desc:平台审核时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime ManagerConfirmDate {get;set;}

           /// <summary>
           /// Desc:平台注释
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ManagerRemark {get;set;}

           /// <summary>
           /// Desc:是否已经退款
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte IsReturn {get;set;}

           /// <summary>
           /// Desc:快递公司
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExpressCompanyName {get;set;}

           /// <summary>
           /// Desc:快递单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ShipOrderNumber {get;set;}

           /// <summary>
           /// Desc:收款人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Payee {get;set;}

           /// <summary>
           /// Desc:收款人账户
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PayeeAccount {get;set;}

           /// <summary>
           /// Desc:退款方式
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int RefundMode {get;set;}

           /// <summary>
           /// Desc:退款支付状态
           /// Default:2
           /// Nullable:False
           /// </summary>           
           public int RefundPayStatus {get;set;}

           /// <summary>
           /// Desc:退款支付类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int RefundPayType {get;set;}

           /// <summary>
           /// Desc:买家发货时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? BuyerDeliverDate {get;set;}

           /// <summary>
           /// Desc:卖家确认到货时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SellerConfirmArrivalDate {get;set;}

           /// <summary>
           /// Desc:退款批次号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RefundBatchNo {get;set;}

           /// <summary>
           /// Desc:退款异步提交时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? RefundPostTime {get;set;}

           /// <summary>
           /// Desc:退货数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long ReturnQuantity {get;set;}

           /// <summary>
           /// Desc:平台佣金退还
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal ReturnPlatCommission {get;set;}

           /// <summary>
           /// Desc:申请次数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ApplyNumber {get;set;}

           /// <summary>
           /// Desc:凭证图片1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CertPic1 {get;set;}

           /// <summary>
           /// Desc:凭证图片2
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CertPic2 {get;set;}

           /// <summary>
           /// Desc:凭证图片3
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CertPic3 {get;set;}

    }
}
