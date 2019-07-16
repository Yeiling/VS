using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_ImageAd
    {
           public Himall_ImageAd(){


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
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:图片的存放URL
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ImageUrl {get;set;}

           /// <summary>
           /// Desc:图片的调整地址
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Url {get;set;}

           /// <summary>
           /// Desc:是否是横向长广告
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte IsTransverseAD {get;set;}

           /// <summary>
           /// Desc:微信头像
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int TypeId {get;set;}

    }
}
