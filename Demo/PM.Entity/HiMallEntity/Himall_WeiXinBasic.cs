using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_WeiXinBasic
    {
           public Himall_WeiXinBasic(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:微信Ticket
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Ticket {get;set;}

           /// <summary>
           /// Desc:微信Ticket过期日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime TicketOutTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AppId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AccessToken {get;set;}

    }
}
