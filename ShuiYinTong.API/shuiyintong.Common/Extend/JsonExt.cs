using Newtonsoft.Json;

namespace shuiyintong.Common.Extend
{
    /// <summary>
    /// Json序列化
    /// </summary>
    public static class JsonExt
    {
        /// <summary>
        /// 对象序列化成Json字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public static string ToJson<T>(this T obj, _Formatting f = _Formatting.Indented)
        {
            var ff = Formatting.Indented;
            if (f == _Formatting.None)
                ff = Formatting.None;

            string json = JsonConvert.SerializeObject(obj, new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                Formatting = ff
            });
            return json;
        }

        /// <summary>
        /// Json字符串序列化成对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T ToObject<T>(this string json)
        {
            if (json == null)
                return default(T);
            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// 枚举格式设定
        /// </summary>
        public enum _Formatting
        {
            None = 0,
            Indented = 1
        }

    }
}
