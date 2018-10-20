using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///Book 的摘要说明
/// </summary>
public class Book
{
    /// <summary>
    /// 书所对应的bookType号
    /// </summary>
    private string _bookType;
    public string bookType
    {
        get { return _bookType; }
        set { _bookType = value; }
    }

    /// <summary>
    /// 书所对应的ISBN号
    /// </summary>
    private string _bookISBN;
    public string bookISBN
    {
        get { return _bookISBN; }
        set { _bookISBN = value; }
    }

    /// <summary>
    /// 书名
    /// </summary>
    private string _bookTitle;
    public string bookTitle
    {
        get { return _bookTitle; }
        set { _bookTitle = value; }
    }

    /// <summary>
    /// 作者
    /// </summary>
    private string _bookAuthor;
    public string bookAuthor
    {
        get { return _bookAuthor; }
        set { _bookAuthor = value; }
    }

    /// <summary>
    /// 价格
    /// </summary>
    private double _bookPrice;
    public double bookPrice
    {
        get { return _bookPrice; }
        set { _bookPrice = value; }
    }

}

