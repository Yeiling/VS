using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///用户IP日志
    ///</summary>
    [SugarTable("tb_userIP")]
    public partial class tb_userIP
    {
           public tb_userIP(){


           }
           /// <summary>
           /// Desc:用户IP
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string userIP {get;set;}

           /// <summary>
           /// Desc:时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? createtime {get;set;}

           /// <summary>
           /// Desc:用户名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string username {get;set;}

           /// <summary>
           /// Desc:接口名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string jkname {get;set;}

           /// <summary>
           /// Desc:机构名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bankName {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? state {get;set;}

           /// <summary>
           /// Desc:次数
           /// Default:1
           /// Nullable:True
           /// </summary>           
           public int? count {get;set;}

           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsIdentity=true)]
           public int Id {get;set;}

    }
}
