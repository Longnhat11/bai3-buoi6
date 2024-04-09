using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3_buoi6
{
    internal class Program
    {
    public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Console.WriteLine($"Truoc khi doi cho: a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"Sau khi doi cho: a = {a}, b = {b}");

            string x = "hello";
            string y = "world";
            Console.WriteLine($"Truoc khi doi cho: x = {x}, y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"Sau khi doi cho: x = {x}, y = {y}");
        }
    }
}
