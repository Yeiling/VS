using ServiceLibrary.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLibrary
{
    public class TestDITwo : TestDInterface
    {
        private readonly string Key;
        public TestDITwo()
        { }
        public TestDITwo(ConfigOption option)
        {
            Key = option.Key;
        }
        public string GetStr(string str) => str;

    }
}
