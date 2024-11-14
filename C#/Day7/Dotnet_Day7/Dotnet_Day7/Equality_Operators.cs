using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day7
{
    class Equality_Operators
    {

        static void Main()
        {
            //Value Type
            int i = 10, j = 10;
            Console.WriteLine(i==j);
            Console.WriteLine(i.Equals(j));
            Console.WriteLine("*****************************");
            //reference type
            string str1 = "Hello";
            string str2 = "Hello";
            string str3 = "hello";
            Console.WriteLine(str1==str2); //true
            Console.WriteLine(str1==str3); //false

            Console.WriteLine(str1.Equals(str2)); //true
            Console.WriteLine(str1.Equals(str3)); //false

            Console.WriteLine("-------------------------------");
            object obj = "Hello";
            object obj1 = "hello";

            Console.WriteLine(obj1==obj); //true
            Console.WriteLine(obj1.Equals(obj)); //true

            Console.WriteLine("------------Compare To----------------");
            int a = 5;
            int b = 7;
            int c = 5;
            Console.WriteLine(a.CompareTo(b)); //False
            Console.WriteLine(b.CompareTo(a)); //False
            Console.WriteLine(c.CompareTo(a)); //True

            Console.WriteLine("------------with strings----------------");
            string s1 = "b";
            string s2 = "bas";
            Console.WriteLine(object.ReferenceEquals(s1,s2));

            s1 = s2;
            Console.WriteLine("Post Assignment " +object.ReferenceEquals(s1,s2));
            Console.Read();
        }
    }
}