using Newtonsoft.Json;

namespace shuiyintong.Common.Extend
{
    public static class JsonExt
    {  
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

        public static T ToObject<T>(this string json)
        {
            if (json == null)
                return default(T);
            return JsonConvert.DeserializeObject<T>(json);
        }

        public enum _Formatting
        {
            None = 0,
            Indented = 1
        }

    }
}
