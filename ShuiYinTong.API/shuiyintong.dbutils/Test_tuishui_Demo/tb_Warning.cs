using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///风险预警表
    ///</summary>
    [SugarTable("tb_Warning")]
    public partial class tb_Warning
    {
           public tb_Warning(){


           }
           /// <summary>
           /// Desc:主键ID
           /// Default:replace(newid(),'-','')
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:数据更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SysUpdateTime {get;set;}

           /// <summary>
           /// Desc:预警主题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarningTitle {get;set;}

           /// <summary>
           /// Desc:预警来源
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarningType {get;set;}

           /// <summary>
           /// Desc:预警级别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarningLevel {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarningStatus {get;set;}

           /// <summary>
           /// Desc:预警规则
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarningRoule {get;set;}

           /// <summary>
           /// Desc:预警内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarningContent {get;set;}

           /// <summary>
           /// Desc:处理意见
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Advice {get;set;}

           /// <summary>
           /// Desc:订单状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarningStep {get;set;}

           /// <summary>
           /// Desc:订单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrderId {get;set;}

           /// <summary>
           /// Desc:用款ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string YKId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? createtime {get;set;}

           /// <summary>
           /// Desc:预警编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string warningNo {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarningSort {get;set;}

           /// <summary>
           /// Desc:授信编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string orderNo {get;set;}

           /// <summary>
           /// Desc:用款编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ykNo {get;set;}

    }
}
