using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_Member
    {
           public Himall_Member(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserName {get;set;}

           /// <summary>
           /// Desc:密码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Password {get;set;}

           /// <summary>
           /// Desc:密码加盐
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string PasswordSalt {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Nick {get;set;}

           /// <summary>
           /// Desc:性别
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Sex {get;set;}

           /// <summary>
           /// Desc:邮件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Email {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CreateDate {get;set;}

           /// <summary>
           /// Desc:省份ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int TopRegionId {get;set;}

           /// <summary>
           /// Desc:省市区ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int RegionId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RealName {get;set;}

           /// <summary>
           /// Desc:电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CellPhone {get;set;}

           /// <summary>
           /// Desc:QQ
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string QQ {get;set;}

           /// <summary>
           /// Desc:街道地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Address {get;set;}

           /// <summary>
           /// Desc:是否禁用
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte Disabled {get;set;}

           /// <summary>
           /// Desc:最后登录日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime LastLoginDate {get;set;}

           /// <summary>
           /// Desc:下单次数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int OrderNumber {get;set;}

           /// <summary>
           /// Desc:总消费金额（不排除退款）
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal TotalAmount {get;set;}

           /// <summary>
           /// Desc:总消费金额（不排除退款）
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal Expenditure {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Points {get;set;}

           /// <summary>
           /// Desc:头像
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Photo {get;set;}

           /// <summary>
           /// Desc:商家父账号ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long ParentSellerId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:支付密码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PayPwd {get;set;}

           /// <summary>
           /// Desc:支付密码加密字符
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PayPwdSalt {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long InviteUserId {get;set;}

           /// <summary>
           /// Desc:会员生日
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? BirthDay {get;set;}

           /// <summary>
           /// Desc:职业
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Occupation {get;set;}

           /// <summary>
           /// Desc:净消费金额（排除退款）
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal NetAmount {get;set;}

           /// <summary>
           /// Desc:最后消费时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? LastConsumptionTime {get;set;}

           /// <summary>
           /// Desc:用户来源终端
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Platform {get;set;}

    }
}
