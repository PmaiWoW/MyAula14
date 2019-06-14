using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        public void GetMinMax1(out double min, out double max)
        {
            // Maneira c# (programação por objetos)
            Sort();
            min = this[0];
            max = this[Count - 1];

            // Maneira C (programação procedimental)
            // min = this[0];
            // max = this[0];
            // 
            // for (int i = 1; i < Count; i++)
            // {
            //     if (this[i] < min) min = this[i];
            //     else (this[i] > max) max = this[i];
            // }
        }

        public struct MinMax2
        {
            public double Min { get; }
            public double Max { get; }

            public MinMax2(double min, double max)
            {
                Min = min;
                Max = max;
            }
        }

        public MinMax2 GetMinMax2()
        {
            double min, max;

            GetMinMax1(out min, out max);

            return new MinMax2(min, max);
        }

        public Tuple<double,double> GetMinMax3()
        {
            double min, max;

            GetMinMax1(out min, out max);

            return new Tuple<double, double>(min, max);
        }
    }
}
