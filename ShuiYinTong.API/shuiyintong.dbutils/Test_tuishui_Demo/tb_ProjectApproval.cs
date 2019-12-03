using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///授信---项目审批信息
    ///</summary>
    [SugarTable("tb_ProjectApproval")]
    public partial class tb_ProjectApproval
    {
           public tb_ProjectApproval(){


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
           /// Desc:审批意见---1-->通过/0-->拒绝
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string approvalOpinion {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remarks {get;set;}

           /// <summary>
           /// Desc:企业规模---大型/中型/小型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string enterpriseScale {get;set;}

           /// <summary>
           /// Desc:划型企业---按照四部委标准定义
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string planningEnterprise {get;set;}

           /// <summary>
           /// Desc:营业收入
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string businessIncome {get;set;}

           /// <summary>
           /// Desc:从业人员
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string practitioners {get;set;}

           /// <summary>
           /// Desc:资产总额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string totalAssets {get;set;}

           /// <summary>
           /// Desc:企业以及关键人是否满足人行征信准入条件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IsFitReq {get;set;}

           /// <summary>
           /// Desc:企业消贷比(分值)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string proportion {get;set;}

           /// <summary>
           /// Desc:企业未结清贷款余额（分值）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string loanBalance {get;set;}

           /// <summary>
           /// Desc:企业法定代表人最近24个自然月最高连续逾期次数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string overdueFrequency {get;set;}

           /// <summary>
           /// Desc:企业法定代表人最近24个自然月累计逾期次数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string overdueTotalFrequency {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? createTime {get;set;}

    }
}
