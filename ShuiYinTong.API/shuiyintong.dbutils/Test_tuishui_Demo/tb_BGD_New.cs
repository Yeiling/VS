using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///报关单信息
    ///</summary>
    [SugarTable("tb_BGD_New")]
    public partial class tb_BGD_New
    {
           public tb_BGD_New(){


           }
           /// <summary>
           /// Desc:主键ID
           /// Default:replace(newid(),'-','')
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:数据更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SysUpdateTime {get;set;}

           /// <summary>
           /// Desc:企业名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NAME {get;set;}

           /// <summary>
           /// Desc:海关代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string QYDM {get;set;}

           /// <summary>
           /// Desc:报关单号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BGD_NO {get;set;}

           /// <summary>
           /// Desc:离境日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LJ_DATE {get;set;}

           /// <summary>
           /// Desc:商品代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CMCODE {get;set;}

           /// <summary>
           /// Desc:商品名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CMNAME {get;set;}

           /// <summary>
           /// Desc:单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DWCODE {get;set;}

           /// <summary>
           /// Desc:人民币出口额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RMB_AMT {get;set;}

           /// <summary>
           /// Desc:美元出口额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string USD_AMT {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HGCMNAME {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string YM {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CMUNIT {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HXD_NO {get;set;}

    }
}
