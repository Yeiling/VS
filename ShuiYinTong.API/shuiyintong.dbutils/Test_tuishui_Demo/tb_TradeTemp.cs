using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///保理申请表单临时表
    ///</summary>
    [SugarTable("tb_TradeTemp")]
    public partial class tb_TradeTemp
    {
           public tb_TradeTemp(){


           }
           /// <summary>
           /// Desc:主键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:订单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ProductOrderId {get;set;}

           /// <summary>
           /// Desc:日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Date {get;set;}

           /// <summary>
           /// Desc:从什么渠道了解到我司
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WhereGetFormCn {get;set;}

           /// <summary>
           /// Desc:从什么渠道了解到我司
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WhereGetFormEn {get;set;}

           /// <summary>
           /// Desc:企业名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SellerNameCn {get;set;}

           /// <summary>
           /// Desc:主营产品
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SellerNameEn {get;set;}

           /// <summary>
           /// Desc:成立日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EstablishTime {get;set;}

           /// <summary>
           /// Desc:注册资本
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RegisterCapital {get;set;}

           /// <summary>
           /// Desc:注册资本币种
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RegisterCapitalCur {get;set;}

           /// <summary>
           /// Desc:法人代表
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LegalRepresentativeCn {get;set;}

           /// <summary>
           /// Desc:法人代表
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LegalRepresentativeEn {get;set;}

           /// <summary>
           /// Desc:主营产品
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MainProductCn {get;set;}

           /// <summary>
           /// Desc:主营产品
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MainProductEn {get;set;}

           /// <summary>
           /// Desc:年营业额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Turnover {get;set;}

           /// <summary>
           /// Desc:年营业额币种
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TurnoverCur {get;set;}

           /// <summary>
           /// Desc:主营市场
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MainMarketCn {get;set;}

           /// <summary>
           /// Desc:主营市场
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MainMarketEn {get;set;}

           /// <summary>
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AddressCn {get;set;}

           /// <summary>
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AddressEn {get;set;}

           /// <summary>
           /// Desc:买方企业
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BuyerNameCn {get;set;}

           /// <summary>
           /// Desc:买方企业
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BuyerNameEn {get;set;}

           /// <summary>
           /// Desc:合作日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HistoryOfCooperation {get;set;}

           /// <summary>
           /// Desc:年采购额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Revenue {get;set;}

           /// <summary>
           /// Desc:年采购额币种
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RevenueCur {get;set;}

           /// <summary>
           /// Desc:最近一次采购额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LatestOrderPlan {get;set;}

           /// <summary>
           /// Desc:最近一次采购额币种
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LatestOrderPlanCur {get;set;}

           /// <summary>
           /// Desc:是否上市
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PublicOrPrivate {get;set;}

           /// <summary>
           /// Desc:是否提供财报
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FinancialReports {get;set;}

           /// <summary>
           /// Desc:买方地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BuyerAddressCn {get;set;}

           /// <summary>
           /// Desc:买方地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BuyerAddressEn {get;set;}

           /// <summary>
           /// Desc:所属地区
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AreaCn {get;set;}

           /// <summary>
           /// Desc:其他所属地区
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OtherAreaCn {get;set;}

           /// <summary>
           /// Desc:所属地区
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AreaEn {get;set;}

           /// <summary>
           /// Desc:其他所属地区
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OtherAreaEn {get;set;}

           /// <summary>
           /// Desc:应收帐款金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AccountsReceivable {get;set;}

           /// <summary>
           /// Desc:应收帐款金额币种
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AccountsReceivableCur {get;set;}

           /// <summary>
           /// Desc:应收帐款到期日
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DueDate {get;set;}

           /// <summary>
           /// Desc:帐期日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreditTermsCn {get;set;}

           /// <summary>
           /// Desc:其他帐期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OtherCreditTermsCn {get;set;}

           /// <summary>
           /// Desc:帐期日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreditTermsEn {get;set;}

           /// <summary>
           /// Desc:其他帐期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OtherCreditTermsEn {get;set;}

           /// <summary>
           /// Desc:经办人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TransactorCn {get;set;}

           /// <summary>
           /// Desc:经办人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TransactorEn {get;set;}

           /// <summary>
           /// Desc:联系方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ContactEn {get;set;}

           /// <summary>
           /// Desc:联系方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CommentsCn {get;set;}

           /// <summary>
           /// Desc:客户建议
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CommentsEn {get;set;}

           /// <summary>
           /// Desc:期待回复时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExpectingTime {get;set;}

           /// <summary>
           /// Desc:客户建议
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RemarksEn {get;set;}

           /// <summary>
           /// Desc:订单状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BLStatus {get;set;}

           /// <summary>
           /// Desc:收款帐号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BenefiAccount {get;set;}

           /// <summary>
           /// Desc:收款开户行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BenefiBankCn {get;set;}

           /// <summary>
           /// Desc:收款开户行swift码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BenefiBankSwift {get;set;}

           /// <summary>
           /// Desc:放款帐号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FangKuanAccount {get;set;}

           /// <summary>
           /// Desc:放款银行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FangKuanBank {get;set;}

           /// <summary>
           /// Desc:放款swift码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FangKuanBankSwift {get;set;}

           /// <summary>
           /// Desc:还款帐号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HuanKuanAccount {get;set;}

           /// <summary>
           /// Desc:还款银行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HuanKuanBank {get;set;}

           /// <summary>
           /// Desc:还款银行swift码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HuanKuanBankSwift {get;set;}

           /// <summary>
           /// Desc:收款银行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BenefiBankEn {get;set;}

           /// <summary>
           /// Desc:收款人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Beneficiary {get;set;}

           /// <summary>
           /// Desc:收款人地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BenefiAddress {get;set;}

           /// <summary>
           /// Desc:收款人开户行地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BenefiBankAddress {get;set;}

           /// <summary>
           /// Desc:收款人开户行IBAN码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BenefiIBANNo {get;set;}

           /// <summary>
           /// Desc:签字人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SignatoryCn {get;set;}

           /// <summary>
           /// Desc:签字人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SignatoryEn {get;set;}

           /// <summary>
           /// Desc:签字人职位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SignatoryPosition {get;set;}

    }
}
