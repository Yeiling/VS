using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class HiMall_Shop
    {
           public HiMall_Shop(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:店铺等级
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long GradeId {get;set;}

           /// <summary>
           /// Desc:店铺名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ShopName {get;set;}

           /// <summary>
           /// Desc:店铺LOGO路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Logo {get;set;}

           /// <summary>
           /// Desc:预留子域名，未使用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SubDomains {get;set;}

           /// <summary>
           /// Desc:预留主题，未使用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Theme {get;set;}

           /// <summary>
           /// Desc:是否是官方自营店
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte IsSelf {get;set;}

           /// <summary>
           /// Desc:店铺状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ShopStatus {get;set;}

           /// <summary>
           /// Desc:审核拒绝原因
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RefuseReason {get;set;}

           /// <summary>
           /// Desc:店铺创建日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CreateDate {get;set;}

           /// <summary>
           /// Desc:店铺过期日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime EndDate {get;set;}

           /// <summary>
           /// Desc:公司名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CompanyName {get;set;}

           /// <summary>
           /// Desc:公司省市区
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int CompanyRegionId {get;set;}

           /// <summary>
           /// Desc:公司地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CompanyAddress {get;set;}

           /// <summary>
           /// Desc:公司电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CompanyPhone {get;set;}

           /// <summary>
           /// Desc:公司员工数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int CompanyEmployeeCount {get;set;}

           /// <summary>
           /// Desc:公司注册资金
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal CompanyRegisteredCapital {get;set;}

           /// <summary>
           /// Desc:联系人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ContactsName {get;set;}

           /// <summary>
           /// Desc:联系电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ContactsPhone {get;set;}

           /// <summary>
           /// Desc:联系Email
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ContactsEmail {get;set;}

           /// <summary>
           /// Desc:营业执照号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BusinessLicenceNumber {get;set;}

           /// <summary>
           /// Desc:营业执照
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string BusinessLicenceNumberPhoto {get;set;}

           /// <summary>
           /// Desc:营业执照所在地
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int BusinessLicenceRegionId {get;set;}

           /// <summary>
           /// Desc:营业执照有效期开始
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? BusinessLicenceStart {get;set;}

           /// <summary>
           /// Desc:营业执照有效期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? BusinessLicenceEnd {get;set;}

           /// <summary>
           /// Desc:法定经营范围
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BusinessSphere {get;set;}

           /// <summary>
           /// Desc:组织机构代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrganizationCode {get;set;}

           /// <summary>
           /// Desc:组织机构执照
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrganizationCodePhoto {get;set;}

           /// <summary>
           /// Desc:一般纳税人证明
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GeneralTaxpayerPhot {get;set;}

           /// <summary>
           /// Desc:银行开户名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankAccountName {get;set;}

           /// <summary>
           /// Desc:公司银行账号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankAccountNumber {get;set;}

           /// <summary>
           /// Desc:开户银行支行名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankName {get;set;}

           /// <summary>
           /// Desc:支行联行号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankCode {get;set;}

           /// <summary>
           /// Desc:开户银行所在地
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int BankRegionId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankPhoto {get;set;}

           /// <summary>
           /// Desc:税务登记证
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TaxRegistrationCertificate {get;set;}

           /// <summary>
           /// Desc:税务登记证号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TaxpayerId {get;set;}

           /// <summary>
           /// Desc:纳税人识别号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TaxRegistrationCertificatePhoto {get;set;}

           /// <summary>
           /// Desc:支付凭证
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PayPhoto {get;set;}

           /// <summary>
           /// Desc:支付注释
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PayRemark {get;set;}

           /// <summary>
           /// Desc:商家发货人名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SenderName {get;set;}

           /// <summary>
           /// Desc:商家发货人地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SenderAddress {get;set;}

           /// <summary>
           /// Desc:商家发货人电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SenderPhone {get;set;}

           /// <summary>
           /// Desc:运费
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal Freight {get;set;}

           /// <summary>
           /// Desc:多少钱开始免运费
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal FreeFreight {get;set;}

           /// <summary>
           /// Desc:注册步骤
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Stage {get;set;}

           /// <summary>
           /// Desc:商家发货人省市区
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int SenderRegionId {get;set;}

           /// <summary>
           /// Desc:营业执照证书
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BusinessLicenseCert {get;set;}

           /// <summary>
           /// Desc:商品证书
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProductCert {get;set;}

           /// <summary>
           /// Desc:其他证书
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OtherCert {get;set;}

           /// <summary>
           /// Desc:法人代表
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string legalPerson {get;set;}

           /// <summary>
           /// Desc:公司成立日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CompanyFoundingDate {get;set;}

           /// <summary>
           /// Desc:0、企业；1、个人
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int BusinessType {get;set;}

           /// <summary>
           /// Desc:身份证号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IDCard {get;set;}

           /// <summary>
           /// Desc:身份证URL
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IDCardUrl {get;set;}

           /// <summary>
           /// Desc:身份证照片URL2
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IDCardUrl2 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WeiXinNickName {get;set;}

           /// <summary>
           /// Desc:微信性别;0、男；1、女
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? WeiXinSex {get;set;}

           /// <summary>
           /// Desc:微信地区
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WeiXinAddress {get;set;}

           /// <summary>
           /// Desc:微信真实姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WeiXinTrueName {get;set;}

           /// <summary>
           /// Desc:微信标识符
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WeiXinOpenId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WeiXinImg {get;set;}

           /// <summary>
           /// Desc:商家是否开启自动分配订单
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte AutoAllotOrder {get;set;}

           /// <summary>
           /// Desc:商家是否开启自动打印
           /// Default:b'0'
           /// Nullable:False
           /// </summary>           
           public bool IsAutoPrint {get;set;}

           /// <summary>
           /// Desc:打印张数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int PrintCount {get;set;}

           /// <summary>
           /// Desc:是否开启头部图片广告
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public byte IsOpenTopImageAd {get;set;}

    }
}
