using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_ExpressInfo
    {
           public Himall_ExpressInfo(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:快递名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:淘宝编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TaobaoCode {get;set;}

           /// <summary>
           /// Desc:快递100对应物流编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Kuaidi100Code {get;set;}

           /// <summary>
           /// Desc:快递鸟物流公司编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string KuaidiNiaoCode {get;set;}

           /// <summary>
           /// Desc:快递面单宽度
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Width {get;set;}

           /// <summary>
           /// Desc:快递面单高度
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Height {get;set;}

           /// <summary>
           /// Desc:快递公司logo
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Logo {get;set;}

           /// <summary>
           /// Desc:快递公司面单背景图片
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BackGroundImage {get;set;}

           /// <summary>
           /// Desc:快递公司状态（0：正常，1：删除）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CreateDate {get;set;}

    }
}
