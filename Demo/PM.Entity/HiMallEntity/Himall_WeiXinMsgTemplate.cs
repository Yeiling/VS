using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_WeiXinMsgTemplate
    {
           public Himall_WeiXinMsgTemplate(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:消息类别
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int MessageType {get;set;}

           /// <summary>
           /// Desc:消息模板编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TemplateNum {get;set;}

           /// <summary>
           /// Desc:消息模板ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TemplateId {get;set;}

           /// <summary>
           /// Desc:更新日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime UpdateDate {get;set;}

           /// <summary>
           /// Desc:是否启用
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte IsOpen {get;set;}

           /// <summary>
           /// Desc:是否小程序微信通知
           /// Default:0000
           /// Nullable:False
           /// </summary>           
           public byte UserInWxApplet {get;set;}

    }
}
