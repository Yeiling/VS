using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_OrderInvoice
    {
           public Himall_OrderInvoice(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:订单编号
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long OrderId {get;set;}

           /// <summary>
           /// Desc:发票类型（1:普通发票、2:电子发票、3:增值税发票）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int InvoiceType {get;set;}

           /// <summary>
           /// Desc:发票抬头
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InvoiceTitle {get;set;}

           /// <summary>
           /// Desc:税号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InvoiceCode {get;set;}

           /// <summary>
           /// Desc:发票明细(个人、公司)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InvoiceContext {get;set;}

           /// <summary>
           /// Desc:注册地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RegisterAddress {get;set;}

           /// <summary>
           /// Desc:注册电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RegisterPhone {get;set;}

           /// <summary>
           /// Desc:开户银行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankName {get;set;}

           /// <summary>
           /// Desc:银行帐号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankNo {get;set;}

           /// <summary>
           /// Desc:收票人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RealName {get;set;}

           /// <summary>
           /// Desc:收票人手机号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CellPhone {get;set;}

           /// <summary>
           /// Desc:收票人邮箱
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Email {get;set;}

           /// <summary>
           /// Desc:收票人地址区域ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int RegionID {get;set;}

           /// <summary>
           /// Desc:收票人详细地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Address {get;set;}

           /// <summary>
           /// Desc:订单完成后多少天开具增值税发票
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int VatInvoiceDay {get;set;}

    }
}
