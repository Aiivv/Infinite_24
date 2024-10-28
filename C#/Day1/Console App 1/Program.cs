using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_1
{
    internal class Program
    {
        static void Main()
        {
            //Console.WriteLine("Enter your first name: ");
            //string fname=Console.ReadLine();
            //Console.WriteLine("Enter your Last Name: ");
            //string lname=Console.ReadLine();
            ////Console.WriteLine("Your name is " + fname + lname);
            //Console.WriteLine("Your FirstName is: {0} and your LastName is :{1}", fname, lname);
            Program prog =new Program();
            prog.TypeConversions();
            prog.Ref_value_conversion();
            prog.Nullable_Eg();
        }
        public void TypeConversions()
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
            string str = "100";
            //x=int.Parse(str);
            //Console.WriteLine(x);
            Console.WriteLine(z);
            //Console.Read();
            //if we change the value of f to a bigger no then we see the casting operartor displays the maximum
            //capacity of the integer data type wherease the conversion function throws the exception of
            //overflow 
            //int result;
            bool success = int.TryParse(str, out int result);

            if (success == true)
            {
                Console.WriteLine("The parsed Number is {0}",result);
            }
            else
            {
                Console.WriteLine("Invalid Data ..Could not Parse");    
            }
            
           
        }
        public void Ref_value_conversion()
        {
            int i = 10; //value type
            object o;   //reference type
            o = i; //boxing
            Console.WriteLine(o);
            i = (int)o;  //unboxing with a cast

            float Marks;
            Console.WriteLine("Enter Marks: ");
            Marks = float.Parse(Console.ReadLine());//Unboxing
            Console.WriteLine("ds"+ Marks);

            //the above can also be written using conversion function as below
            Console.WriteLine("Enter Marks: ");
            Marks =Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("afd"+ Marks);

            string s1 = "ABC";
            o = s1;
            Console.WriteLine(s1);
            Console.WriteLine(o);
           
        }
        public void Nullable_Eg()
        {
            string str = null;
            int ? num1= 90;
            int num2;

            if(num1 ==null)
            {
                num2 = 0;
            }
            else
            {
                num2 = Convert.ToInt32(num1); //or as below
                
                //num2 = (int)num1;
            }
            Console.WriteLine(num2);
            //the above 8 lines of code can be replaced in a single line 
            //using null coalescing operator (??)
            Console.WriteLine("------------------");
            num2 = num1 ?? 0;
            Console.WriteLine(num2);
            Console.Read();
        }
    }
}
