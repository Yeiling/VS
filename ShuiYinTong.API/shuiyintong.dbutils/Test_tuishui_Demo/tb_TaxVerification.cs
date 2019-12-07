using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///授信---退税账户核验信息
    ///</summary>
    [SugarTable("tb_TaxVerification")]
    public partial class tb_TaxVerification
    {
           public tb_TaxVerification(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:replace(newid(),'-','')
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public Guid ID {get;set;}

           /// <summary>
           /// Desc:平台项目账号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string platformAcctNo {get;set;}

           /// <summary>
           /// Desc:企业名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string enterpriseName {get;set;}

           /// <summary>
           /// Desc:户名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string accountName {get;set;}

           /// <summary>
           /// Desc:账号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string acctNo {get;set;}

           /// <summary>
           /// Desc:开户行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string openBank {get;set;}

           /// <summary>
           /// Desc:是否退税账户---(1:是 0：否)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsDrawback {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? createTime {get;set;}

    }
}
