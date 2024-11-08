using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DotNet_Day6
{
    class Program
    {
        public void Swap(int number1 , int number2)
        {
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine("Swapping of 2 integers, number 1 {0} and number 2 {1}", number1, number2);
        }
         
        public char Swap(char a, char b)
        {
            char temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Swapping of 2 characters, character 1 {0} and character 2 {1}", a, b);
            return temp;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Program p=new Program();
            p.Swap(23, 45);   //go to line 12 //early binding 
            p.Swap('a', 'b');  
            Console.Read();
        }
    }
}