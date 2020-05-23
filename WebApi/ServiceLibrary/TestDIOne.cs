using ServiceLibrary.Config;

namespace ServiceLibrary
{
    /// <summary>
    /// 依赖注入
    /// </summary>
    public class TestDIOne: TestDInterface
    {
        private readonly string Key;
        public TestDIOne()
        { }
        public TestDIOne(ConfigOption option)
        {
            Key = option.Key;
        }

        public string GetStr(string str) => Key + "---" + str;

    }
}
