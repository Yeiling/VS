using System;

namespace shuiyintong.Entity
{
    /// <summary>
    /// 返回结果基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseResponse<T>
    {
        public byte ResponseType { get; set; }
        public int Code { get; set; }
        public T Data { get; set; }
        public string DateTime { get; set; }
    }
}
