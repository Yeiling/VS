using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///执行公告(企业)
    ///</summary>
    [SugarTable("tb_SYT_ZXGG")]
    public partial class tb_SYT_ZXGG
    {
           public tb_SYT_ZXGG(){


           }
           /// <summary>
           /// Desc:主键ID
           /// Default:replace(newid(),'-','')
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:企业名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_entName {get;set;}

           /// <summary>
           /// Desc:税银通企业id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_ENT_ID {get;set;}

           /// <summary>
           /// Desc:被执行人姓名/名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZXGG_BZXname {get;set;}

           /// <summary>
           /// Desc:执行公告ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZXGG_zxggId {get;set;}

           /// <summary>
           /// Desc:立案日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ZXGG_sortTime {get;set;}

           /// <summary>
           /// Desc:内容概要
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZXGG_body {get;set;}

           /// <summary>
           /// Desc:标题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZXGG_title {get;set;}

           /// <summary>
           /// Desc:被告
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZXGG_pname {get;set;}

           /// <summary>
           /// Desc:执行法院名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZXGG_court {get;set;}

           /// <summary>
           /// Desc:原告
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZXGG_proposer {get;set;}

           /// <summary>
           /// Desc:案号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZXGG_caseNo {get;set;}

           /// <summary>
           /// Desc:执行状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZXGG_caseState {get;set;}

           /// <summary>
           /// Desc:当事人身份证号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZXGG_idcardNo {get;set;}

           /// <summary>
           /// Desc:执行标的金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZXGG_execMoney {get;set;}

           /// <summary>
           /// Desc:执行依据文号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZXGG_case_number {get;set;}

           /// <summary>
           /// Desc:公示信息类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZXGG_disabled {get;set;}

           /// <summary>
           /// Desc:数据更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SysUpdateTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string sxID {get;set;}

    }
}
