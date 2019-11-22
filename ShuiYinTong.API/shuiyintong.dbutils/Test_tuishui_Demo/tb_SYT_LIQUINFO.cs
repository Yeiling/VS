using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///清算信息
    ///</summary>
    [SugarTable("tb_SYT_LIQUINFO")]
    public partial class tb_SYT_LIQUINFO
    {
           public tb_SYT_LIQUINFO(){


           }
           /// <summary>
           /// Desc:主键ID
           /// Default:replace(newid(),'-','')
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:企业名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_entName {get;set;}

           /// <summary>
           /// Desc:税银通企业id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_ENT_ID {get;set;}

           /// <summary>
           /// Desc:清算负责人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LIQ_liqPrincipal {get;set;}

           /// <summary>
           /// Desc:清算责任人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LIQ_ligentity {get;set;}

           /// <summary>
           /// Desc:清算组成员
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LIQ_liqMen {get;set;}

           /// <summary>
           /// Desc:清算完结情况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LIQ_liGst {get;set;}

           /// <summary>
           /// Desc:清算完结日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? LIQ_ligEndDate {get;set;}

           /// <summary>
           /// Desc:债务承接人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LIQ_debtTranee {get;set;}

           /// <summary>
           /// Desc:债权承接人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LIQ_claimTranee {get;set;}

           /// <summary>
           /// Desc:数据更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SysUpdateTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string sxID {get;set;}

    }
}
