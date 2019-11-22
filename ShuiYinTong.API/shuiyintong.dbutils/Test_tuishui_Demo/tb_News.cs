using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///新闻资讯
    ///</summary>
    [SugarTable("tb_News")]
    public partial class tb_News
    {
           public tb_News(){


           }
           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:标题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string title {get;set;}

           /// <summary>
           /// Desc:日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? dates {get;set;}

           /// <summary>
           /// Desc:内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string contents {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string status {get;set;}

           /// <summary>
           /// Desc:阅读次数 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? readCount {get;set;}

           /// <summary>
           /// Desc:类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string type {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

           /// <summary>
           /// Desc:备用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string temp1 {get;set;}

           /// <summary>
           /// Desc:备用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string temp2 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? publishDate {get;set;}

    }
}
