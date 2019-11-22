using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///主要人员信息
    ///</summary>
    [SugarTable("tb_SYT_CENTPERSON")]
    public partial class tb_SYT_CENTPERSON
    {
           public tb_SYT_CENTPERSON(){


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
           /// Desc:姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CENT_name {get;set;}

           /// <summary>
           /// Desc:主要人员id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_PER_ID_CENT {get;set;}

           /// <summary>
           /// Desc:职位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CENT_position {get;set;}

           /// <summary>
           /// Desc:人员总数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? CENT_NUM {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? created_time {get;set;}

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
           public string CENT_sex {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string sxID {get;set;}

    }
}
