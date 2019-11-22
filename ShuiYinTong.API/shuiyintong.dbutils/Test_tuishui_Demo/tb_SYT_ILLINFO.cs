using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///严重违法失信信息
    ///</summary>
    [SugarTable("tb_SYT_ILLINFO")]
    public partial class tb_SYT_ILLINFO
    {
           public tb_SYT_ILLINFO(){


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
           /// Desc:登记注册类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ILL_illegalType {get;set;}

           /// <summary>
           /// Desc:列入原因
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ILL_illegalResultIn {get;set;}

           /// <summary>
           /// Desc:列入日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ILL_illegalDateIn {get;set;}

           /// <summary>
           /// Desc:作出决定机关（列入）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ILL_illegalOrgNameIn {get;set;}

           /// <summary>
           /// Desc:移出原因
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ILL_illegalResultOut {get;set;}

           /// <summary>
           /// Desc:移出日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ILL_illegalDateOut {get;set;}

           /// <summary>
           /// Desc:作出决定机关（移出）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ILL_illegalOrgNameOut {get;set;}

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
