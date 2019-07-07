using System;
using System.Linq;
using System.Text;

namespace PM.Entity.YiiBaidbEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class productlines
    {
           public productlines(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string productLine {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string textDescription {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string htmlDescription {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public byte[] image {get;set;}

    }
}
