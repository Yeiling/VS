using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.SYT_apiDB_TestEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("DVR_USER_LOGIN_INFO")]
    public partial class DVR_USER_LOGIN_INFO
    {
           public DVR_USER_LOGIN_INFO(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string DEVICE_ADDRESS {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int PORT {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string USER_NAME {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PASSWORD {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? IS_ENABLE {get;set;}

    }
}
