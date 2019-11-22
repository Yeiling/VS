using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///回收站
    ///</summary>
    [SugarTable("Base_Recyclebin")]
    public partial class Base_Recyclebin
    {
           public Base_Recyclebin(){


           }
           /// <summary>
           /// Desc:回收站主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Recyclebin_ID {get;set;}

           /// <summary>
           /// Desc:业务名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Recyclebin_Name {get;set;}

           /// <summary>
           /// Desc:对应数据库
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Recyclebin_Database {get;set;}

           /// <summary>
           /// Desc:对应数据表
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Recyclebin_Table {get;set;}

           /// <summary>
           /// Desc:对应字段主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Recyclebin_FieldKey {get;set;}

           /// <summary>
           /// Desc:对应字段值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Recyclebin_EventField {get;set;}

           /// <summary>
           /// Desc:描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Recyclebin_Remark {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateDate {get;set;}

           /// <summary>
           /// Desc:创建用户主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreateUserId {get;set;}

           /// <summary>
           /// Desc:创建用户
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreateUserName {get;set;}

    }
}
