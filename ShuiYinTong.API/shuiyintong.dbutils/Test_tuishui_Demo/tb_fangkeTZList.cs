using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("tb_fangkeTZList")]
    public partial class tb_fangkeTZList
    {
           public tb_fangkeTZList(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:访客台账Id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? FKId {get;set;}

           /// <summary>
           /// Desc:跟进方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FollowUP {get;set;}

           /// <summary>
           /// Desc:反馈状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FKStatus {get;set;}

           /// <summary>
           /// Desc:跟进日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FollowUPTime {get;set;}

           /// <summary>
           /// Desc:跟进记录
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FollowUPRecord {get;set;}

           /// <summary>
           /// Desc:待跟进事项
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Dai_FollowUP {get;set;}

           /// <summary>
           /// Desc:
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateTime {get;set;}

    }
}
