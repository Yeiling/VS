using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///用户权限
    ///</summary>
    [SugarTable("tb_powerGroup")]
    public partial class tb_powerGroup
    {
           public tb_powerGroup(){


           }
           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:权限名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string powerName {get;set;}

           /// <summary>
           /// Desc:权限点
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string power {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? userId {get;set;}

           /// <summary>
           /// Desc:银行名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bankName {get;set;}

    }
}
