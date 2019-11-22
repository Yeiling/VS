using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///企业帐户
    ///</summary>
    [SugarTable("tb_companyAccount")]
    public partial class tb_companyAccount
    {
           public tb_companyAccount(){


           }
           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? userId {get;set;}

           /// <summary>
           /// Desc:帐户类型 1-提款 2-还款 3-退税
           /// Default:2
           /// Nullable:True
           /// </summary>           
           public int? cardtype {get;set;}

           /// <summary>
           /// Desc:支行名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string branchname {get;set;}

           /// <summary>
           /// Desc:企业名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string companyName {get;set;}

           /// <summary>
           /// Desc:卡号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string cardNo {get;set;}

           /// <summary>
           /// Desc:支行号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string branchNo {get;set;}

           /// <summary>
           /// Desc:银行名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bankname {get;set;}

           /// <summary>
           /// Desc:省
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string province {get;set;}

           /// <summary>
           /// Desc:市
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string city {get;set;}

           /// <summary>
           /// Desc:税银通企业ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_ENT_ID {get;set;}

           /// <summary>
           /// Desc:银行确认标志  err 确认失败  suc 确认通过
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bankConfirmFlag {get;set;}

           /// <summary>
           /// Desc:项目ID
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? orderId {get;set;}

           /// <summary>
           /// Desc:项目编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrderNo {get;set;}

    }
}
