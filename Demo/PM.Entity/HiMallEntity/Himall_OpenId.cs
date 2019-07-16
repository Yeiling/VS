using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_OpenId
    {
           public Himall_OpenId(){


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
           public string OpenId {get;set;}

           /// <summary>
           /// Desc:关注时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime SubscribeTime {get;set;}

           /// <summary>
           /// Desc:是否关注
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte IsSubscribe {get;set;}

    }
}
