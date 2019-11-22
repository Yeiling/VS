using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///企业基础信息
    ///</summary>
    [SugarTable("CompanyMessage")]
    public partial class CompanyMessage
    {
           public CompanyMessage(){


           }
           /// <summary>
           /// Desc:键值ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:用户编号
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? userId {get;set;}

           /// <summary>
           /// Desc:用户名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string username {get;set;}

           /// <summary>
           /// Desc:手机号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string userMob {get;set;}

           /// <summary>
           /// Desc:企业名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string companyName {get;set;}

           /// <summary>
           /// Desc:经营范围
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string companyIntro {get;set;}

           /// <summary>
           /// Desc:纳税人识别号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TaxInvoice {get;set;}

           /// <summary>
           /// Desc:海关代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bussinessNo {get;set;}

           /// <summary>
           /// Desc:税务机关代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrganizationNo {get;set;}

           /// <summary>
           /// Desc:退税机关代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string salesubsidiary {get;set;}

           /// <summary>
           /// Desc:退税评级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string rating {get;set;}

           /// <summary>
           /// Desc:企业营业执照
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string registersNo {get;set;}

           /// <summary>
           /// Desc:账号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bankaccount {get;set;}

           /// <summary>
           /// Desc:退税银行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bankname {get;set;}

           /// <summary>
           /// Desc:公司地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string comaddress {get;set;}

           /// <summary>
           /// Desc:企业类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string returnsnumber {get;set;}

           /// <summary>
           /// Desc:排序
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? sort {get;set;}

           /// <summary>
           /// Desc:区域代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string swcode {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? pubdate {get;set;}

           /// <summary>
           /// Desc:创建者
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string createUser {get;set;}

           /// <summary>
           /// Desc:企业分支
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string attribution {get;set;}

           /// <summary>
           /// Desc:是否上传授权书
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? isauthent {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? updatetime {get;set;}

           /// <summary>
           /// Desc:e签宝企业认证 不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string eSignAccountId {get;set;}

           /// <summary>
           /// Desc:e签宝企业认证 不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string eSignSealData {get;set;}

           /// <summary>
           /// Desc:企业认证 不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string realNameServiceId {get;set;}

           /// <summary>
           /// Desc:e签宝企业认证 不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string realNamePayFlag {get;set;}

           /// <summary>
           /// Desc:法人认证标志
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string personAuth {get;set;}

           /// <summary>
           /// Desc:上传证照标志
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string picAuth {get;set;}

           /// <summary>
           /// Desc:客户编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string companyNO {get;set;}

    }
}
