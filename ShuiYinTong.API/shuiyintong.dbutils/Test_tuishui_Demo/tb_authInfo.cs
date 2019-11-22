using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///企业认证信息表
    ///</summary>
    [SugarTable("tb_authInfo")]
    public partial class tb_authInfo
    {
           public tb_authInfo(){


           }
           /// <summary>
           /// Desc:关键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:企业名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string companyName {get;set;}

           /// <summary>
           /// Desc:社会信用代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string creditcode {get;set;}

           /// <summary>
           /// Desc:海关代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string businesscode {get;set;}

           /// <summary>
           /// Desc:法人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FRname {get;set;}

           /// <summary>
           /// Desc:法人电话号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FRtel {get;set;}

           /// <summary>
           /// Desc:法人身份证号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FRIdentityCode {get;set;}

           /// <summary>
           /// Desc:经办人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string JBRname {get;set;}

           /// <summary>
           /// Desc:经办人电话号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string JBRtel {get;set;}

           /// <summary>
           /// Desc:经办人身份证号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string JBRIdentityCode {get;set;}

           /// <summary>
           /// Desc:企业ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? companyId {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? userId {get;set;}

           /// <summary>
           /// Desc:税银通企业ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_ENT_ID {get;set;}

           /// <summary>
           /// Desc:法人个人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FRSYT_PER_Id {get;set;}

           /// <summary>
           /// Desc:经办人个人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string JBRSYT_PER_Id {get;set;}

    }
}
