using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///企业分支机构信息
    ///</summary>
    [SugarTable("tb_SYT_BRANCOM")]
    public partial class tb_SYT_BRANCOM
    {
           public tb_SYT_BRANCOM(){


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
           /// Desc:分支机构名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BRAN_brName {get;set;}

           /// <summary>
           /// Desc:税银通分支机构id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_ENT_ID_FZ {get;set;}

           /// <summary>
           /// Desc:统一社会信用代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BRAN_brCreditCode {get;set;}

           /// <summary>
           /// Desc:分支机构注册号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BRAN_brRegno {get;set;}

           /// <summary>
           /// Desc:分支机构负责人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BRAN_brPrincipal {get;set;}

           /// <summary>
           /// Desc:分支机构地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BRAN_brAddr {get;set;}

           /// <summary>
           /// Desc:经营范围
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BRAN_operateScope {get;set;}

           /// <summary>
           /// Desc:法定代表人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BRAN_oper_name {get;set;}

           /// <summary>
           /// Desc:分支机构法人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_PER_ID_FZ {get;set;}

           /// <summary>
           /// Desc:工商登记机关
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BRAN_belong_org {get;set;}

           /// <summary>
           /// Desc:第三方ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BRAN_id {get;set;}

           /// <summary>
           /// Desc:分支机构企业ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BRAN_branches_id {get;set;}

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
