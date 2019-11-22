using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///城市表
    ///</summary>
    [SugarTable("RZFK_City")]
    public partial class RZFK_City
    {
           public RZFK_City(){


           }
           /// <summary>
           /// Desc:城市ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:上级城市ID，顶级为0一级为城市，二级为区，三级为商圈
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string ParentID {get;set;}

           /// <summary>
           /// Desc:所在层级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Levels {get;set;}

           /// <summary>
           /// Desc:排序值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? OrderSort {get;set;}

           /// <summary>
           /// Desc:城市名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CityName {get;set;}

           /// <summary>
           /// Desc:城市代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CityCode {get;set;}

    }
}
