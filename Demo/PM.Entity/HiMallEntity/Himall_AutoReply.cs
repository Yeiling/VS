using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_AutoReply
    {
           public Himall_AutoReply(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Id {get;set;}

           /// <summary>
           /// Desc:规则名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RuleName {get;set;}

           /// <summary>
           /// Desc:关键词
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Keyword {get;set;}

           /// <summary>
           /// Desc:匹配方式(模糊，完全匹配)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int MatchType {get;set;}

           /// <summary>
           /// Desc:文字回复内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TextReply {get;set;}

           /// <summary>
           /// Desc:是否开启
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int IsOpen {get;set;}

           /// <summary>
           /// Desc:消息回复类型-(关注回复，关键词回复，消息自动回复)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ReplyType {get;set;}

           /// <summary>
           /// Desc:消息内容的类型，1=文本，2=图文素材
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int ReplyContentType {get;set;}

           /// <summary>
           /// Desc:素材ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MediaId {get;set;}

    }
}
