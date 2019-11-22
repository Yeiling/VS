using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///操作日志信息表
    ///</summary>
    [SugarTable("tb_sysActionLog")]
    public partial class tb_sysActionLog
    {
           public tb_sysActionLog(){


           }
           /// <summary>
           /// Desc:关键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:操作人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string operators {get;set;}

           /// <summary>
           /// Desc:操作日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? dates {get;set;}

           /// <summary>
           /// Desc:操作内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string contents {get;set;}

           /// <summary>
           /// Desc:操作
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string action {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

           /// <summary>
           /// Desc:页面来源
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string view {get;set;}

    }
}
