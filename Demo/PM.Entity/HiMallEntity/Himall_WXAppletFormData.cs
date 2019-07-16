using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_WXAppletFormData
    {
           public Himall_WXAppletFormData(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:事件ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long EventId {get;set;}

           /// <summary>
           /// Desc:事件值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EventValue {get;set;}

           /// <summary>
           /// Desc:事件的表单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FormId {get;set;}

           /// <summary>
           /// Desc:事件时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime EventTime {get;set;}

           /// <summary>
           /// Desc:FormId过期时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime ExpireTime {get;set;}

    }
}
