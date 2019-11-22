using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///法定代表人对外投资信息
    ///</summary>
    [SugarTable("tb_SYT_PREINV")]
    public partial class tb_SYT_PREINV
    {
           public tb_SYT_PREINV(){


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
           /// Desc:被投资企业名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FINV_entName {get;set;}

           /// <summary>
           /// Desc:法人对外投资企业id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_ENT_ID_FINV_FR {get;set;}

           /// <summary>
           /// Desc:统一社会信用代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FINV_creditCode {get;set;}

           /// <summary>
           /// Desc:注册号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FINV_regNo {get;set;}

           /// <summary>
           /// Desc:登记注册类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FINV_entType {get;set;}

           /// <summary>
           /// Desc:法定代表人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FINV_frName {get;set;}

           /// <summary>
           /// Desc:法人对外投资企业法人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_PER_ID_FINV_FR {get;set;}

           /// <summary>
           /// Desc:注册资本
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? FINV_regCap {get;set;}

           /// <summary>
           /// Desc:注册币种
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FINV_regCapCur {get;set;}

           /// <summary>
           /// Desc:成立日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? FINV_esDate {get;set;}

           /// <summary>
           /// Desc:工商登记机关
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FINV_regOrg {get;set;}

           /// <summary>
           /// Desc:经营状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FINV_entStatus {get;set;}

           /// <summary>
           /// Desc:注销日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? FINV_canDate {get;set;}

           /// <summary>
           /// Desc:吊销日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? FINV_revDate {get;set;}

           /// <summary>
           /// Desc:认缴出资额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? FINV_subConam {get;set;}

           /// <summary>
           /// Desc:认缴出资币种
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FINV_subCurrency {get;set;}

           /// <summary>
           /// Desc:出资比例
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? FINV_fundedRatio {get;set;}

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
