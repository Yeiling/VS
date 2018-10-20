using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public abstract class Cal
    {
        public double[] dbarr
        {
            get;
            set;
        }

        public Cal()
        { }
        public Cal(params double[] darr)
        {
            this.dbarr = darr;
        }
        //抽象方法不可以有方法体
        public abstract double Jisuan();
    }
}
