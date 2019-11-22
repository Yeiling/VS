using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///机构用户
    ///</summary>
    [SugarTable("tb_Salesman")]
    public partial class tb_Salesman
    {
           public tb_Salesman(){


           }
           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:用户名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string userName {get;set;}

           /// <summary>
           /// Desc:密码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string password {get;set;}

           /// <summary>
           /// Desc:真实姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string realName {get;set;}

           /// <summary>
           /// Desc:别名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string nickName {get;set;}

           /// <summary>
           /// Desc:邮件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string email {get;set;}

           /// <summary>
           /// Desc:qq
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string qq {get;set;}

           /// <summary>
           /// Desc:电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string phone {get;set;}

           /// <summary>
           /// Desc:手机号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string telephone {get;set;}

           /// <summary>
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string address {get;set;}

           /// <summary>
           /// Desc:当前地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string currentAddr {get;set;}

           /// <summary>
           /// Desc:图片链接
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string picUrl {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string userCard {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? times {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? state {get;set;}

           /// <summary>
           /// Desc:权限ID
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? powerGroup {get;set;}

           /// <summary>
           /// Desc:机构名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string attribution {get;set;}

           /// <summary>
           /// Desc:机构信息表ID
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? bId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string user_role {get;set;}

           /// <summary>
           /// Desc:职务
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string departmentposition {get;set;}

           /// <summary>
           /// Desc:首次启用时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? firstOnTime {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string contents {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? updatetime {get;set;}

    }
}
