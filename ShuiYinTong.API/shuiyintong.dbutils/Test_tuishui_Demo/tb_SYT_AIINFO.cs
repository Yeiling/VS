using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///企业变更信息
    ///</summary>
    [SugarTable("tb_SYT_AIINFO")]
    public partial class tb_SYT_AIINFO
    {
           public tb_SYT_AIINFO(){


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
           /// Desc:变更事项
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AL_altItem {get;set;}

           /// <summary>
           /// Desc:变更前内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AL_altBe {get;set;}

           /// <summary>
           /// Desc:变更后内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AL_altAf {get;set;}

           /// <summary>
           /// Desc:变更日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? AL_altDate {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? AL_created_time {get;set;}

           /// <summary>
           /// Desc:历史信息标签
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AL_changerecords_tag {get;set;}

           /// <summary>
           /// Desc:Id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AL_Id {get;set;}

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
