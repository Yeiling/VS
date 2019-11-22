using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Base_SysMenu")]
    public partial class Base_SysMenu
    {
           public Base_SysMenu(){


           }
           /// <summary>
           /// Desc:菜单主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Menu_Id {get;set;}

           /// <summary>
           /// Desc:父节点主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ParentId {get;set;}

           /// <summary>
           /// Desc:菜单名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Menu_Name {get;set;}

           /// <summary>
           /// Desc:菜单标记
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Menu_Title {get;set;}

           /// <summary>
           /// Desc:菜单图标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Menu_Img {get;set;}

           /// <summary>
           /// Desc:类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Menu_Type {get;set;}

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
           /// Nullable:False
           /// </summary>           
           public DateTime CreateDate {get;set;}

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

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MenuBtn {get;set;}

           /// <summary>
           /// Desc:用来区分商户与总站
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? UserId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MenuOrg {get;set;}

    }
}
