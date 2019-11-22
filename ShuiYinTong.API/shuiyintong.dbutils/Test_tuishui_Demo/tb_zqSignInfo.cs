using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///众签合同记录信息
    ///</summary>
    [SugarTable("tb_zqSignInfo")]
    public partial class tb_zqSignInfo
    {
           public tb_zqSignInfo(){


           }
           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int id {get;set;}

           /// <summary>
           /// Desc:文件号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string no {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? status {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? createtime {get;set;}

           /// <summary>
           /// Desc:企业ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string cid {get;set;}

           /// <summary>
           /// Desc:文件名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:pdf链接
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string pdfPath {get;set;}

           /// <summary>
           /// Desc:签署code
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SignerUserCode {get;set;}

           /// <summary>
           /// Desc:类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string type {get;set;}

    }
}
