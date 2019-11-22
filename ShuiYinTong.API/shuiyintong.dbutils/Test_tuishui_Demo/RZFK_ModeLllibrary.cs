using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("RZFK_ModeLllibrary")]
    public partial class RZFK_ModeLllibrary
    {
           public RZFK_ModeLllibrary(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string Model_ID {get;set;}

           /// <summary>
           /// Desc:模型版本
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Model_version {get;set;}

           /// <summary>
           /// Desc:模型名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Model_Name {get;set;}

           /// <summary>
           /// Desc:模型状态1、最新，2、失效，3、暂存
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Model_IsStatus {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? DeleteMark {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreateUser {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ModifyDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ModifyUser {get;set;}

    }
}
