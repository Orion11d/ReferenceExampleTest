//Первый проэкт
//Использование приема данних по ссылке
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRef
{
    class Program
    {
        static void RefExample(ref double a, ref double b)
        {
            double c;
            c = a;
            a = Math.Sqrt(b);
            b = c;
        }
        static void Main(string[] args)
        {
            double x = 10, y = 34;

            RefExample(ref x, ref y);
            Console.WriteLine(x + " " + y);
            Console.ReadLine();
            

        }
    }
}
