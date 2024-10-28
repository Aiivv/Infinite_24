using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
            string fname=Console.ReadLine();
            Console.WriteLine("Enter your Last Name: ");
            string lname=Console.ReadLine();
            //Console.WriteLine("Your name is " + fname + lname);
            Console.WriteLine("Your FirstName is: {0} and your LastName is :{1}", fname, lname);
            Program prog =new Program();
            prog.type_conversions();
        }
        public void type_conversions()
        {
            int i=100;
            float f;
            Console.WriteLine(i);
            f = i;
            Console.WriteLine(f);
            f = 12345.56f;
            int x = (int)f;   //explicit using cast operator
            Console.WriteLine(x);
            x=Convert.ToInt32(f); //using conversion function
            Console.WriteLine(x);
            f =1223434121212.32f;
            int z=(int)f;
            Console.WriteLine(z);
            //z=Convert.ToInt32(f);
            string str = "100lj";
            x=int.Parse(str);
            Console.WriteLine(x);
            Console.WriteLine(z);
            Console.Read();
            //if we change the value of f to a bigger no then we see the casting operartor displays the maximum
            //capacity of the integer data type wherease the conversion function throws the exception of
            //overflow 
        }
    }
}
