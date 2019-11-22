using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///系统角色表
    ///</summary>
    [SugarTable("Base_Roles")]
    public partial class Base_Roles
    {
           public Base_Roles(){


           }
           /// <summary>
           /// Desc:角色主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Roles_ID {get;set;}

           /// <summary>
           /// Desc:父节点主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ParentId {get;set;}

           /// <summary>
           /// Desc:角色名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Roles_Name {get;set;}

           /// <summary>
           /// Desc:条件限制
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Role_Restriction {get;set;}

           /// <summary>
           /// Desc:角色描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Roles_Remark {get;set;}

           /// <summary>
           /// Desc:允许编辑
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? AllowEdit {get;set;}

           /// <summary>
           /// Desc:允许删除
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? AllowDelete {get;set;}

           /// <summary>
           /// Desc:排序吗
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? SortCode {get;set;}

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
           public int? CreateUserId {get;set;}

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
           public int? ModifyUserId {get;set;}

           /// <summary>
           /// Desc:修改用户
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ModifyUserName {get;set;}

    }
}
