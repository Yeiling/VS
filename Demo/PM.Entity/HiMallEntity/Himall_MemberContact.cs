using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_MemberContact
    {
           public Himall_MemberContact(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long UserId {get;set;}

           /// <summary>
           /// Desc:用户类型(0 Email  1 SMS)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int UserType {get;set;}

           /// <summary>
           /// Desc:插件名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ServiceProvider {get;set;}

           /// <summary>
           /// Desc:联系号码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Contact {get;set;}

    }
}
