using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegates
{
    //public delegate double Delegate1(int x, float y, double z);
    //public delegate void Delegate2(int x, float y, double z);
    //public delegate bool Delegate3(string str);

    class GenericDelegates
    {
        //Value-Returning Method
        public static double AddNumbers1(int x, float y, double z)
        {
            return x + y + z;
        }
        //Non-Value-Returning Method
        public static void AddNumbers2(int x, float y, double z)
        {
            Console.WriteLine( x + y + z);
        }
        //Boolean Value-Returning Method
        public static bool CheckLength(string str)
        {
            if (str.Length > 5)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Func<int, float, double, double> f1 = AddNumbers1;            
            double result = f1.Invoke(10, 12.5f, 123.45);
            Console.WriteLine("Func Delegate 1: " + result);

            Action<int, float, double> a1 = AddNumbers2;
            Console.Write("Action Delegate 2: ");
            a1(10, 12.5f, 123.45);


            Predicate<string> d3 = new Predicate<string>(CheckLength);
            Console.WriteLine("Predicate Delegate 3: " + d3("Hello"));

            Func<string,bool> p1 = CheckLength;            
            bool status = p1.Invoke("hello world");
            Console.WriteLine("Func Delegate 3: " + status);

            Console.ReadKey();
        }
    }
}
