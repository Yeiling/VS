using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///留言板
    ///</summary>
    [SugarTable("tb_MessageBoard")]
    public partial class tb_MessageBoard
    {
           public tb_MessageBoard(){


           }
           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? UserId {get;set;}

           /// <summary>
           /// Desc:公司名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ComName {get;set;}

           /// <summary>
           /// Desc:内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Contents {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? AddDate {get;set;}

           /// <summary>
           /// Desc:样式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Style {get;set;}

           /// <summary>
           /// Desc:备用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Reserve1 {get;set;}

           /// <summary>
           /// Desc:备用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Reserve2 {get;set;}

           /// <summary>
           /// Desc:备用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Reserve3 {get;set;}

           /// <summary>
           /// Desc:备用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Reserve4 {get;set;}

    }
}
