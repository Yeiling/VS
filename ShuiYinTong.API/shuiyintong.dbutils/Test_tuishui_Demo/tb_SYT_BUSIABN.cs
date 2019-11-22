using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///经营异常信息
    ///</summary>
    [SugarTable("tb_SYT_BUSIABN")]
    public partial class tb_SYT_BUSIABN
    {
           public tb_SYT_BUSIABN(){


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
           /// Desc:列入日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ABN_dateIn {get;set;}

           /// <summary>
           /// Desc:列入决定机关
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ABN_orgNameIn {get;set;}

           /// <summary>
           /// Desc:移出原因
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ABN_resultOut {get;set;}

           /// <summary>
           /// Desc:移出日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ABN_dateOut {get;set;}

           /// <summary>
           /// Desc:移出决定机关
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ABN_orgNameOut {get;set;}

           /// <summary>
           /// Desc:列入原因
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ABN_in_reason {get;set;}

           /// <summary>
           /// Desc:注册号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ABN_reg_no {get;set;}

           /// <summary>
           /// Desc:所在省份
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ABN_province {get;set;}

           /// <summary>
           /// Desc:公示信息类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ABN_disabled {get;set;}

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
