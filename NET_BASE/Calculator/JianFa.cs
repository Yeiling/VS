using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class JianFa : Cal
    {
        public JianFa()
        { }
        public JianFa(params double[] dou)
            : base(dou)
        { }

        public override double Jisuan()
        {
            double result = 0;
            for (int i = 0; i < this.dbarr.Length; i++)
            {
                if (i == 0)
                {
                    result = this.dbarr[i];
                    continue;
                }
                else
                {
                    result -= this.dbarr[i];
                }
            }
            return result;
        }
    }
}
