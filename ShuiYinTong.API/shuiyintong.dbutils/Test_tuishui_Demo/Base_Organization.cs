using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///组织机构、部门表
    ///</summary>
    [SugarTable("Base_Organization")]
    public partial class Base_Organization
    {
           public Base_Organization(){


           }
           /// <summary>
           /// Desc:部门主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Organization_ID {get;set;}

           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Organization_Code {get;set;}

           /// <summary>
           /// Desc:部门名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Organization_Name {get;set;}

           /// <summary>
           /// Desc:外线电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Organization_InnerPhone {get;set;}

           /// <summary>
           /// Desc:内线电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Organization_OuterPhone {get;set;}

           /// <summary>
           /// Desc:主负责人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Organization_Manager {get;set;}

           /// <summary>
           /// Desc:副负责人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Organization_AssistantManager {get;set;}

           /// <summary>
           /// Desc:传真
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Organization_Fax {get;set;}

           /// <summary>
           /// Desc:邮政区号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Organization_Zipcode {get;set;}

           /// <summary>
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Organization_Address {get;set;}

           /// <summary>
           /// Desc:父节点主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ParentId {get;set;}

           /// <summary>
           /// Desc:备注说明
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Organization_Remark {get;set;}

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
