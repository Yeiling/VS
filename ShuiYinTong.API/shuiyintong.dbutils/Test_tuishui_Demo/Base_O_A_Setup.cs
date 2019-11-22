using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Base_O_A_Setup")]
    public partial class Base_O_A_Setup
    {
           public Base_O_A_Setup(){


           }
           /// <summary>
           /// Desc:快捷主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Setup_ID {get;set;}

           /// <summary>
           /// Desc:用户主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string User_ID {get;set;}

           /// <summary>
           /// Desc:快捷功能名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Setup_IName {get;set;}

           /// <summary>
           /// Desc:导航地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NavigateUrl {get;set;}

           /// <summary>
           /// Desc:目标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Target {get;set;}

           /// <summary>
           /// Desc:菜单图标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Setup_Img {get;set;}

           /// <summary>
           /// Desc:描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Setup_Remak {get;set;}

           /// <summary>
           /// Desc:排序吗
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? SortCode {get;set;}

    }
}
