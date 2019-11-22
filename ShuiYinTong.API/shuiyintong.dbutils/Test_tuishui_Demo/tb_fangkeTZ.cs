using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("tb_fangkeTZ")]
    public partial class tb_fangkeTZ
    {
           public tb_fangkeTZ(){


           }
           /// <summary>
           /// Desc:
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
           public string CompanyName {get;set;}

           /// <summary>
           /// Desc:注册地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RegAddress {get;set;}

           /// <summary>
           /// Desc:公司地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ComAddress {get;set;}

           /// <summary>
           /// Desc:统一社会信用代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreditCode {get;set;}

           /// <summary>
           /// Desc:联系人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Contacts {get;set;}

           /// <summary>
           /// Desc:联系方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ContactsPhone {get;set;}

           /// <summary>
           /// Desc:邮箱
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Email {get;set;}

           /// <summary>
           /// Desc:反馈状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Status {get;set;}

           /// <summary>
           /// Desc:跟进方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FollowUP {get;set;}

           /// <summary>
           /// Desc:操作人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Operator {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateTime {get;set;}

    }
}
