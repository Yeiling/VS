using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///附加属性
    ///</summary>
    [SugarTable("Base_AppendProperty")]
    public partial class Base_AppendProperty
    {
           public Base_AppendProperty(){


           }
           /// <summary>
           /// Desc:附加属性主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Property_ID {get;set;}

           /// <summary>
           /// Desc:所属功能
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Property_Function {get;set;}

           /// <summary>
           /// Desc:功能路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Property_FunctionUrl {get;set;}

           /// <summary>
           /// Desc:控件ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Property_Control_ID {get;set;}

           /// <summary>
           /// Desc:属性名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Property_Name {get;set;}

           /// <summary>
           /// Desc:控件类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Property_Control_Type {get;set;}

           /// <summary>
           /// Desc:控件数据源
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Property_Control_DataSource {get;set;}

           /// <summary>
           /// Desc:控件长度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Property_Control_Length {get;set;}

           /// <summary>
           /// Desc:最大长度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Property_Control_Maxlength {get;set;}

           /// <summary>
           /// Desc:控件样式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Property_Control_Style {get;set;}

           /// <summary>
           /// Desc:验证控件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Property_Control_Validator {get;set;}

           /// <summary>
           /// Desc:合并列
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Property_Colspan {get;set;}

           /// <summary>
           /// Desc:事件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Property_Event {get;set;}

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
