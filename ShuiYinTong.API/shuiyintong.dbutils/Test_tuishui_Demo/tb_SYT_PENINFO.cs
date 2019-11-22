using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///行政处罚信息
    ///</summary>
    [SugarTable("tb_SYT_PENINFO")]
    public partial class tb_SYT_PENINFO
    {
           public tb_SYT_PENINFO(){


           }
           /// <summary>
           /// Desc:主键ID
           /// Default:replace(newid(),'-','')
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:税银通企业id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_ENT_ID {get;set;}

           /// <summary>
           /// Desc:决定文书号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PEN_penDecNo {get;set;}

           /// <summary>
           /// Desc:行政处罚类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PEN_illegactTypeName {get;set;}

           /// <summary>
           /// Desc:行政处罚内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PEN_penResultName {get;set;}

           /// <summary>
           /// Desc:决定机关名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PEN_penAuthName {get;set;}

           /// <summary>
           /// Desc:处罚决定日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? PEN_penDecissDate {get;set;}

           /// <summary>
           /// Desc:公示日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? PEN_openDate {get;set;}

           /// <summary>
           /// Desc:行政处罚决定书内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PEN_caseBook {get;set;}

           /// <summary>
           /// Desc:案由
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PEN_caseReason {get;set;}

           /// <summary>
           /// Desc:处罚依据
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PEN_penBasis {get;set;}

           /// <summary>
           /// Desc:案件结果
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PEN_caseResult {get;set;}

           /// <summary>
           /// Desc:处罚金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? PEN_penAm {get;set;}

           /// <summary>
           /// Desc:处罚执行情况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PEN_penExest {get;set;}

           /// <summary>
           /// Desc:案发日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? PEN_caseTime {get;set;}

           /// <summary>
           /// Desc:案值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PEN_caseVal {get;set;}

           /// <summary>
           /// Desc:执行类别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PEN_exeSort {get;set;}

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
