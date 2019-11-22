using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("tb_SYT_entper_basinfo")]
    public partial class tb_SYT_entper_basinfo
    {
           public tb_SYT_entper_basinfo(){


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
           /// Desc:姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:税银通个人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_PER_Id {get;set;}

           /// <summary>
           /// Desc:身份证号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string idNO {get;set;}

           /// <summary>
           /// Desc:联系方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Tele {get;set;}

           /// <summary>
           /// Desc:婚姻状况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Marriage {get;set;}

           /// <summary>
           /// Desc:教育程度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Edu {get;set;}

           /// <summary>
           /// Desc:从业经验
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? WorkingExp {get;set;}

           /// <summary>
           /// Desc:人员类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Position {get;set;}

           /// <summary>
           /// Desc:企业名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EntName {get;set;}

           /// <summary>
           /// Desc:税银通企业ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_ENT_Id {get;set;}

    }
}
