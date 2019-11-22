using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///企业规模
    ///</summary>
    [SugarTable("tb_QYGM")]
    public partial class tb_QYGM
    {
           public tb_QYGM(){


           }
           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:企业ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? cId {get;set;}

           /// <summary>
           /// Desc:行业
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string industry {get;set;}

           /// <summary>
           /// Desc:营业收入
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? YYSR {get;set;}

           /// <summary>
           /// Desc:从业人数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CYRY {get;set;}

           /// <summary>
           /// Desc:资产总额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ZCZE {get;set;}

           /// <summary>
           /// Desc:企业规模
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string QYGM {get;set;}

           /// <summary>
           /// Desc:行业代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string industryCode {get;set;}

    }
}
