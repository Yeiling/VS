using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///企业认证
    ///</summary>
    [SugarTable("tb_SignAccountVerify")]
    public partial class tb_SignAccountVerify
    {
           public tb_SignAccountVerify(){


           }
           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:银行帐号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string BankAccount {get;set;}

           /// <summary>
           /// Desc:支行号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Bank_settle_no {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Status {get;set;}

           /// <summary>
           /// Desc:企业ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? CompanyId {get;set;}

           /// <summary>
           /// Desc:商户名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BusiName {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BusiNo {get;set;}

           /// <summary>
           /// Desc:日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Dates {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VerifyCode {get;set;}

           /// <summary>
           /// Desc:流水号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrderNo {get;set;}

    }
}
