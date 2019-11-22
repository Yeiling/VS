using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///股权冻结信息
    ///</summary>
    [SugarTable("tb_SYT_FROZINFO")]
    public partial class tb_SYT_FROZINFO
    {
           public tb_SYT_FROZINFO(){


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
           /// Desc:被执行人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FROZ_judicialInv {get;set;}

           /// <summary>
           /// Desc:被执行人证件类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FROZ_judicialCerTypeName {get;set;}

           /// <summary>
           /// Desc:被执行人证件号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FROZ_judicialCerNo {get;set;}

           /// <summary>
           /// Desc:冻结数额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FROZ_judicialFroAm {get;set;}

           /// <summary>
           /// Desc:冻结状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FROZ_judicialFrozState {get;set;}

           /// <summary>
           /// Desc:冻结执行法院
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FROZ_frozAuth {get;set;}

           /// <summary>
           /// Desc:冻结执行事项
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FROZ_frozExecuteItem {get;set;}

           /// <summary>
           /// Desc:冻结执行通知书文号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FROZ_frozExecuteNo {get;set;}

           /// <summary>
           /// Desc:冻结执行裁定书文号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FROZ_frozDocNo {get;set;}

           /// <summary>
           /// Desc:冻结期限自
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? FROZ_frozFrom {get;set;}

           /// <summary>
           /// Desc:冻结期限至
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? FROZ_frozTo {get;set;}

           /// <summary>
           /// Desc:冻结期限
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? FROZ_frozDeadline {get;set;}

           /// <summary>
           /// Desc:冻结公示日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? FROZ_frozPublicDate {get;set;}

           /// <summary>
           /// Desc:续行冻结期限自
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? FROZ_keepFrozFrom {get;set;}

           /// <summary>
           /// Desc:续行冻结期限至
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? FROZ_keepFrozTo {get;set;}

           /// <summary>
           /// Desc:续行冻结期限
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? FROZ_keepFrozDeadline {get;set;}

           /// <summary>
           /// Desc:解冻执行法院
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FROZ_thawAuth {get;set;}

           /// <summary>
           /// Desc:解冻执行事项
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FROZ_thawExecuteItem {get;set;}

           /// <summary>
           /// Desc:解冻执行通知书文号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FROZ_thawExecuteNo {get;set;}

           /// <summary>
           /// Desc:解冻执行裁定书文号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FROZ_thawDocNo {get;set;}

           /// <summary>
           /// Desc:解冻日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? FROZ_thawDate {get;set;}

           /// <summary>
           /// Desc:解冻公示日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? FROZ_thawPublicDate {get;set;}

           /// <summary>
           /// Desc:失效日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? FROZ_invalidTime {get;set;}

           /// <summary>
           /// Desc:失效原因
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FROZ_invalidReason {get;set;}

           /// <summary>
           /// Desc:解冻说明
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FROZ_thawComment {get;set;}

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
