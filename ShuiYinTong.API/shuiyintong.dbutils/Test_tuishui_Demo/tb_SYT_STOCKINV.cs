using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///股东出资信息
    ///</summary>
    [SugarTable("tb_SYT_STOCKINV")]
    public partial class tb_SYT_STOCKINV
    {
           public tb_SYT_STOCKINV(){


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
           /// Desc:股东名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STI_shareholderName {get;set;}

           /// <summary>
           /// Desc:股东id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_PER_ID_STI {get;set;}

           /// <summary>
           /// Desc:股东类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STI_shareholderType {get;set;}

           /// <summary>
           /// Desc:股东证件类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STI_blicType {get;set;}

           /// <summary>
           /// Desc:股东证件号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STI_blicNo {get;set;}

           /// <summary>
           /// Desc:认缴出资额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? STI_subConam {get;set;}

           /// <summary>
           /// Desc:认缴出资币种
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STI_subCurrency {get;set;}

           /// <summary>
           /// Desc:认缴出资日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? STI_conDate {get;set;}

           /// <summary>
           /// Desc:认缴出资比例
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? STI_fundedRatio {get;set;}

           /// <summary>
           /// Desc:国别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STI_country {get;set;}

           /// <summary>
           /// Desc:认缴出资方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STI_conform {get;set;}

           /// <summary>
           /// Desc:股东总人数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? STI_invamount {get;set;}

           /// <summary>
           /// Desc:股东出资总和
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STI_sumconam {get;set;}

           /// <summary>
           /// Desc:股东出资比例总和
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? STI_invsumfundedratio {get;set;}

           /// <summary>
           /// Desc:实缴出资额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STI_real_capi_items_real_capi {get;set;}

           /// <summary>
           /// Desc:实缴出资日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? STI_real_capi_items_real_capi_date {get;set;}

           /// <summary>
           /// Desc:实缴出资方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STI_real_capi_items_invest_type {get;set;}

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
