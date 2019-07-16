using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_FreightAreaDetail
    {
           public Himall_FreightAreaDetail(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:运费模板ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long FreightTemplateId {get;set;}

           /// <summary>
           /// Desc:模板地区Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long FreightAreaId {get;set;}

           /// <summary>
           /// Desc:省份ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ProvinceId {get;set;}

           /// <summary>
           /// Desc:城市ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int CityId {get;set;}

           /// <summary>
           /// Desc:区ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int CountyId {get;set;}

           /// <summary>
           /// Desc:乡镇的ID用逗号隔开
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TownIds {get;set;}

    }
}
