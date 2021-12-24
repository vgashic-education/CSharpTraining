using System;
using System.Collections;

namespace CS.BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();

            list.Add(123); // boxing
            list.Add(Math.PI); // boxing
            list.Add("bla bla bla"); // no boxing here
            list.Add(33); // boxing
            list.Add(12m); // boxing
            list.Add(DateTime.Now); // boxing
            list.Add(false); // boxing
            list.Add(true); // boxing

            foreach (var item in list)
            {
                Console.WriteLine(FormatForSql(item));
            }
        }


        private static string FormatForSql(object obj)
        {
            if (obj == null)
            {
                return "null";
            }

            if (obj is decimal)
            {
                var dec = (decimal)obj; // unboxing
                return dec.ToString("N2");
            }

            if (obj is double)
            {
                var d = (double)obj; // unboxing
                return d.ToString();
            }

            if (obj is int)
            {
                var i = (int)obj; // unboxing
                return i.ToString();
            }

            if (obj is DateTime)
            {
                var dt = (DateTime)obj; // unboxing
                return $"'{dt:yyyy-MM-dd}'";
            }

            if (obj is bool)
            {
                var b = (bool)obj; // unboxing
                return b ? "1" : "0";
            }

            return $"'{obj}'";
        }
    }
}
