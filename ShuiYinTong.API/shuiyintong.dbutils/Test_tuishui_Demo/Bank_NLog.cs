using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///银行API接口日志表
    ///</summary>
    [SugarTable("Bank_NLog")]
    public partial class Bank_NLog
    {
           public Bank_NLog(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:银行名称或者接口名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankName {get;set;}

           /// <summary>
           /// Desc:控制器名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Controller {get;set;}

           /// <summary>
           /// Desc:Action名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ACTION {get;set;}

           /// <summary>
           /// Desc:Http请求类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HttpType {get;set;}

           /// <summary>
           /// Desc:方法
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Method {get;set;}

           /// <summary>
           /// Desc:时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Logged {get;set;}

           /// <summary>
           /// Desc:错误级别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LEVEL {get;set;}

           /// <summary>
           /// Desc:错误信息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Message {get;set;}

           /// <summary>
           /// Desc:发生异常点
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Logger {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? Status {get;set;}

    }
}
