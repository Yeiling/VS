using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///登录日志
    ///</summary>
    [SugarTable("Base_SysLoginlog")]
    public partial class Base_SysLoginlog
    {
           public Base_SysLoginlog(){


           }
           /// <summary>
           /// Desc:登录日志主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYS_LOGINLOG_ID {get;set;}

           /// <summary>
           /// Desc:登录IP
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYS_LOGINLOG_IP {get;set;}

           /// <summary>
           /// Desc:登录时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? SYS_LOGINLOG_TIME {get;set;}

           /// <summary>
           /// Desc:登录账户
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string User_Account {get;set;}

           /// <summary>
           /// Desc:登录状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? SYS_LOGINLOG_STATUS {get;set;}

           /// <summary>
           /// Desc:IP所在地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OWNER_address {get;set;}

    }
}
