using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///企业用户
    ///</summary>
    [SugarTable("tb_userInfo")]
    public partial class tb_userInfo
    {
           public tb_userInfo(){


           }
           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:用户名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string userName {get;set;}

           /// <summary>
           /// Desc:登录密码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string password {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OperatePassword {get;set;}

           /// <summary>
           /// Desc:手机号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string userMob {get;set;}

           /// <summary>
           /// Desc:电子邮箱
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string email {get;set;}

           /// <summary>
           /// Desc:注册日期
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? registerDate {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? loginDate {get;set;}

           /// <summary>
           /// Desc:最新日期
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? lastDate {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string creditlevel {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? levelScore {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string currentRole {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? borrowScore {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string picture {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? isren1 {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? isren2 {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UserIP {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string usercode {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? wronum {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string agentName {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string agentCity {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? status {get;set;}

           /// <summary>
           /// Desc:0 企业用户 1 机构  2税单贷用户 3小程序用户
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? userType {get;set;}

           /// <summary>
           /// Desc:身份证名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IdentifyName {get;set;}

           /// <summary>
           /// Desc:身份证号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IdentifyCode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string openID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string token {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? tokenCreateDatetime {get;set;}

    }
}
