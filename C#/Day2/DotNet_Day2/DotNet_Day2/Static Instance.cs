using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day2
{
    internal class StaticInstance 
    {
        static void Main(string[] args)
        {
            StaticInstance obj=new StaticInstance();
            StaticInstance.EvenNos_Generation(14);
            int sum=obj.AddNos(9, 24);
            Console.WriteLine(sum);
            TestClass.Method1();
        }

        public int AddNos(int a ,int b)
        {
            
            Console.WriteLine(a+b);
            return a+b;
        }

        public static void EvenNos_Generation(int num)
        {
            int i = 0;
            while (i < num)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
        }
    }
    class TestClass
    {
        public static void Method1()
        {
            Console.WriteLine("This is a static function of another class ");
        }
    }

}
