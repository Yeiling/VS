using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("RZFK_ModeRuleList")]
    public partial class RZFK_ModeRuleList
    {
           public RZFK_ModeRuleList(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Rule_ID {get;set;}

           /// <summary>
           /// Desc:准入规则
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Rule_Summary {get;set;}

           /// <summary>
           /// Desc:执行条件:1、满足以下所有条件。2、满足一下任一条件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Rule_condition {get;set;}

           /// <summary>
           /// Desc:所属模块
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string QuotaType_ID {get;set;}

           /// <summary>
           /// Desc:决策结论
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Result {get;set;}

           /// <summary>
           /// Desc:风险预警代表预警级别,评级模型代表权重
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string item1 {get;set;}

           /// <summary>
           /// Desc:1,业务准入、2,评级模型、3,预警模型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ModelType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreateUser {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ModifyDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ModifyUser {get;set;}

    }
}
