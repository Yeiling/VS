using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///权限按钮操作
    ///</summary>
    [SugarTable("Base_Button")]
    public partial class Base_Button
    {
           public Base_Button(){


           }
           /// <summary>
           /// Desc:按钮ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Button_ID {get;set;}

           /// <summary>
           /// Desc:按钮名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Button_Name {get;set;}

           /// <summary>
           /// Desc:按钮标记
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Button_Title {get;set;}

           /// <summary>
           /// Desc:按钮图标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Button_Img {get;set;}

           /// <summary>
           /// Desc:Button_Code
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Button_Code {get;set;}

           /// <summary>
           /// Desc:排序吗
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? SortCode {get;set;}

           /// <summary>
           /// Desc:类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Button_Type {get;set;}

           /// <summary>
           /// Desc:描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Button_Remak {get;set;}

           /// <summary>
           /// Desc:删除标记 
           /// Default:1
           /// Nullable:True
           /// </summary>           
           public int? DeleteMark {get;set;}

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

           /// <summary>
           /// Desc:修改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ModifyDate {get;set;}

           /// <summary>
           /// Desc:修改用户主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ModifyUserId {get;set;}

           /// <summary>
           /// Desc:修改用户
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ModifyUserName {get;set;}

    }
}
