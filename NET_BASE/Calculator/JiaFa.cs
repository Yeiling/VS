using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class JiaFa : Cal
    {
        public JiaFa()
        { }
        public JiaFa(params double[] dou)
            : base(dou)
        { }

        public override double Jisuan()
        {
            return this.dbarr.Sum();  //Sum()是数组的一个求和方法
        }
    }
}
