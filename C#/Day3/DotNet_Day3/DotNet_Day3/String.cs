using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day3
{
    public class String
    {
        public void Stringsd()
        {

            string sd = "Hello";
            Console.WriteLine("First Time String is {0} and value is{1} ", sd.GetHashCode(), sd);
            sd = "Hello World";
            Console.WriteLine("Second Time s is {0} and value is {1}: ", sd.GetHashCode(), sd);
            string s1 = "Csharp";
            Console.WriteLine("s1 hash is {0} and value is {1}", s1.GetHashCode(), s1);
            string s2 = "Csharp";
            Console.WriteLine("s2 has is {0} and value is {1}", s2.GetHashCode(), s2);
            string s3 = sd;
            Console.WriteLine("S3 reference is same as s {0}  and value is {1} ", s3.GetHashCode(), s3);
            Console.WriteLine("----------------Value of all string objects-------------------");
            Console.WriteLine(sd + " " + s1 + " " + s2 + " " + s3);
            s3 = "hi";
            Console.WriteLine(sd);
            Console.WriteLine(s3);
            Console.ReadLine();

            char[] carr = new char[] { 'w', 'e','l','c','o','m','e' };
            string mystring=new string(carr); //will not consider string pool
            //but will allocate seperate memory like other objects
            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine("----------------Original hash of string builder--------------------");
            Console.WriteLine("sbs hash code is {0} and the value is {1}",sb.GetHashCode(), sb);
            sb.Append("C# string builders");
            Console.WriteLine("----------------After hash of string builder-------------------");
            Console.WriteLine("sbs hash code is {0} and the value is {1}", sb.GetHashCode(), sb);
        }
        
    }
}
