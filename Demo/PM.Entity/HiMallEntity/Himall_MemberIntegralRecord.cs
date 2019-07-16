using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_MemberIntegralRecord
    {
           public Himall_MemberIntegralRecord(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long MemberId {get;set;}

           /// <summary>
           /// Desc:用户名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserName {get;set;}

           /// <summary>
           /// Desc:兑换类型（登录、下单等）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int TypeId {get;set;}

           /// <summary>
           /// Desc:积分数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Integral {get;set;}

           /// <summary>
           /// Desc:记录日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime RecordDate {get;set;}

           /// <summary>
           /// Desc:说明
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ReMark {get;set;}

    }
}
