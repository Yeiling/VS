using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_CityExpressConfig
    {
           public Himall_CityExpressConfig(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:商家编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:是否开启
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public byte IsEnable {get;set;}

           /// <summary>
           /// Desc:商户号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string source_id {get;set;}

           /// <summary>
           /// Desc:appKey
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string app_key {get;set;}

           /// <summary>
           /// Desc:appSecret
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string app_secret {get;set;}

    }
}
