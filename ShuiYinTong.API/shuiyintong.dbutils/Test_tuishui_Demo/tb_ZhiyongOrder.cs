using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///支用订单
    ///</summary>
    [SugarTable("tb_ZhiyongOrder")]
    public partial class tb_ZhiyongOrder
    {
           public tb_ZhiyongOrder(){


           }
           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string status {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? userId {get;set;}

           /// <summary>
           /// Desc:流程编号，备用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZhiyongNo {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? createtime {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? updatetime {get;set;}

           /// <summary>
           /// Desc:银行账户余额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? BankEdu {get;set;}

           /// <summary>
           /// Desc:可用额度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? AvailableEdu {get;set;}

           /// <summary>
           /// Desc:转出额度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ZCEdu {get;set;}

           /// <summary>
           /// Desc:退税账号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TuishuiAccountNo {get;set;}

           /// <summary>
           /// Desc:转出账户户名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZCAccountName {get;set;}

           /// <summary>
           /// Desc:转出账户账号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZCAccountNo {get;set;}

           /// <summary>
           /// Desc:转出账户开户行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZCAccountBank {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

           /// <summary>
           /// Desc:转账金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? bankZZEdu {get;set;}

           /// <summary>
           /// Desc:转账时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? bankZZtime {get;set;}

           /// <summary>
           /// Desc:转账是否成功。0 否 1 是
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bankZZSuc {get;set;}

           /// <summary>
           /// Desc:担保审批后 银行账户余额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? DBBankEdu {get;set;}

           /// <summary>
           /// Desc:担保审批后 可用额度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? DBAvailableEdu {get;set;}

    }
}
