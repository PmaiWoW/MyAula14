using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            double min1, max1;
            SuperList.MinMax2 MM2Struct;
            Tuple<double, double> MM3Tuple;

            Console.WriteLine("Hello World!");
            SuperList lst = new SuperList() { 12.3, 1.0, 0.4, 16, 92 };
            
            lst.GetMinMax1(out min1, out max1);

            Console.WriteLine($"Min1: {min1}\nMax1: {max1}");

            // 2nd GetMinMax
            MM2Struct = lst.GetMinMax2();

            Console.WriteLine($"Min2: {MM2Struct.Min}\n" +
                $"Max2: {MM2Struct.Max}");

            // 3rd GetMinMax
            MM3Tuple = lst.GetMinMax3();

            Console.WriteLine($"Min3: {MM3Tuple.Item1}\n" +
                $"Max3: {MM3Tuple.Item2}");
        }
    }
}
