using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("tb_testTask")]
    public partial class tb_testTask
    {
           public tb_testTask(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsIdentity=true)]
           public int id {get;set;}

           /// <summary>
           /// Desc:触发时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? createtime {get;set;}

           /// <summary>
           /// Desc:触发类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TaskType {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

    }
}
