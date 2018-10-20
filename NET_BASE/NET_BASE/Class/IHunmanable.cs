using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NET_BASE.Class
{
    public interface IHunmanable
    {
        string SayHello(string name, string sex, int age);
        void Run();
    }
}
