using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///企业证照
    ///</summary>
    [SugarTable("CompanyPic")]
    public partial class CompanyPic
    {
           public CompanyPic(){


           }
           /// <summary>
           /// Desc:键值ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:公司ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? companyId {get;set;}

           /// <summary>
           /// Desc:证照路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string imgUrl {get;set;}

           /// <summary>
           /// Desc:证照类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string imgTitle {get;set;}

           /// <summary>
           /// Desc:上传日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? pubdate {get;set;}

           /// <summary>
           /// Desc:排序
           /// Default:1
           /// Nullable:True
           /// </summary>           
           public int? sort {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string status {get;set;}

           /// <summary>
           /// Desc:企业名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string companyName {get;set;}

           /// <summary>
           /// Desc:税银通企业ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_ENT_ID {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? userId {get;set;}

    }
}
