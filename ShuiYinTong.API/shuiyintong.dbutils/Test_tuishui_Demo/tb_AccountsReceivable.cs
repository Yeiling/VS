using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///保理应收帐款明细
    ///</summary>
    [SugarTable("tb_AccountsReceivable")]
    public partial class tb_AccountsReceivable
    {
           public tb_AccountsReceivable(){


           }
           /// <summary>
           /// Desc:键值ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:订单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ProductOrderId {get;set;}

           /// <summary>
           /// Desc:买方名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DebtorName {get;set;}

           /// <summary>
           /// Desc:买方地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DebtorAddress {get;set;}

           /// <summary>
           /// Desc:买方州号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DebtorStateNo {get;set;}

           /// <summary>
           /// Desc:发票号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InvoiceNo {get;set;}

           /// <summary>
           /// Desc:开票日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InvoiceDate {get;set;}

           /// <summary>
           /// Desc:发货日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ShipDate {get;set;}

           /// <summary>
           /// Desc:发票金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InvoiceAmount {get;set;}

           /// <summary>
           /// Desc:预付款
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AdvanceAmount {get;set;}

           /// <summary>
           /// Desc:剩余款项
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OutstandingAmount {get;set;}

           /// <summary>
           /// Desc:截止日
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DueDate {get;set;}

           /// <summary>
           /// Desc:总金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PricePay {get;set;}

           /// <summary>
           /// Desc:金额总计
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TotalPrice {get;set;}

           /// <summary>
           /// Desc:附件号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExhibitNo {get;set;}

           /// <summary>
           /// Desc:日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Date {get;set;}

           /// <summary>
           /// Desc:借款日
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? LoanDate {get;set;}

           /// <summary>
           /// Desc:还款日
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? repayDate {get;set;}

           /// <summary>
           /// Desc:还款memo
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string repayMemo {get;set;}

           /// <summary>
           /// Desc:类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string reStatus {get;set;}

           /// <summary>
           /// Desc:还款方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string repayType {get;set;}

           /// <summary>
           /// Desc:总价币种
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TotalPriceCur {get;set;}

           /// <summary>
           /// Desc:应付款货币
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PricePayCur {get;set;}

    }
}
