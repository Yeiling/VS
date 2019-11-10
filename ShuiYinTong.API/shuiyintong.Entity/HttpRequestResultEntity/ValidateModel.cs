namespace shuiyintong.Entity.HttpRequestResultEntity
{
    /// <summary>
    /// 参数（请求参数实体属性验证）返回对象
    /// </summary>
    public class ValidateModel
    {
        /// <summary>
        /// 字段名称
        /// </summary>
        public string Field { get; }
        /// <summary>
        /// 错误消息
        /// </summary>
        public string Message { get; }


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="field">字段名称</param>
        /// <param name="message">错误消息</param>
        public ValidateModel(string field, string message)
        {
            Field = field != string.Empty ? field : null;
            Message = message;
        }
    }
}
