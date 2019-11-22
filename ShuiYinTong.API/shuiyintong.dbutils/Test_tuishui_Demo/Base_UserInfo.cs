using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///用户帐户表
    ///</summary>
    [SugarTable("Base_UserInfo")]
    public partial class Base_UserInfo
    {
           public Base_UserInfo(){


           }
           /// <summary>
           /// Desc:用户主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string User_ID {get;set;}

           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string User_Code {get;set;}

           /// <summary>
           /// Desc:用户账户
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string User_Account {get;set;}

           /// <summary>
           /// Desc:用户密码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string User_Pwd {get;set;}

           /// <summary>
           /// Desc:用户姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string User_Name {get;set;}

           /// <summary>
           /// Desc:性别 1：男、0：女
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? User_Sex {get;set;}

           /// <summary>
           /// Desc:职称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Title {get;set;}

           /// <summary>
           /// Desc:电子邮件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Email {get;set;}

           /// <summary>
           /// Desc:系统样式选择
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Theme {get;set;}

           /// <summary>
           /// Desc:密码提示问题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Question {get;set;}

           /// <summary>
           /// Desc:密码提示答案
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AnswerQuestion {get;set;}

           /// <summary>
           /// Desc:删除标记 1：正常，2：锁定，0：删除
           /// Default:1
           /// Nullable:True
           /// </summary>           
           public int? DeleteMark {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateDate {get;set;}

           /// <summary>
           /// Desc:创建用户主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreateUserId {get;set;}

           /// <summary>
           /// Desc:创建用户
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreateUserName {get;set;}

           /// <summary>
           /// Desc:修改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ModifyDate {get;set;}

           /// <summary>
           /// Desc:修改用户主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ModifyUserId {get;set;}

           /// <summary>
           /// Desc:修改用户
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ModifyUserName {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string User_Remark {get;set;}

    }
}
