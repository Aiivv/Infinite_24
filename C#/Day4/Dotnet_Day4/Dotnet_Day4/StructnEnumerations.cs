using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day4
{
    enum Cities { Agra, Banglore, Chennai, Delhi, Hyderabad, Kolkata, Mumbai, Vizag };
    struct Customer
    {
        public int custrating;

        internal Customer(int crating)
        {
            this.custrating = crating;
        }

        public void givecustrating()
        {
            Console.WriteLine("Enter rating for the Cust: ");
            custrating = Convert.ToInt32(Console.ReadLine());
        }
    }
    internal class StructnEnumerations
    {
        public static void Enum_Operations()
        {
            foreach (int x in Enum.GetValues(typeof(Cities)))
            {
                //Console.Write(x);

                if (x == 1)
                {
                    Console.WriteLine(Enum.GetName(typeof(Cities), x) +" is a Garden city! ");
                }
                else if (x == 3)
                {
                    Console.WriteLine(Enum.GetName(typeof(Cities),x)+ " is a Capital ");
                }

                else if (x == 4)
                {
                    Console.WriteLine(Enum.GetName(typeof(Cities),x)+" is a monument city");
                }
                else
                {
                    Console.WriteLine(Enum.GetName(typeof(Cities),x)+" is a city");
                }
            }
            Console.WriteLine("-----------------------------------------------");

            foreach (string z in Enum.GetNames(typeof(Cities)))
            {
                Console.WriteLine(z);
            }
        }
        public static void TestStructnClass()
        {
            //objects of structures 
            Customer cust1 = new Customer(21);
            cust1.custrating = 10;
            Console.WriteLine(cust1.custrating);

            Customer cust2 = new Customer(20);
            cust2 = cust1; //cust1 data gets copied onto cust2
            Console.WriteLine("Customer 1 rating: " + cust1.custrating + " Customer 2 rating: " + cust2.custrating);
            cust2.custrating = 2;
            Console.WriteLine("After Changes :");
            Console.WriteLine("Customer 1 Rating: " + cust1.custrating + " Customer 2 rating : " + cust2.custrating);
        }

        public static void Main(string[] args)
        {
            //StructnEnumerations.TestStructnClass();
            StructnEnumerations.Enum_Operations();

            var myvar = 56;
            myvar = "sd";
            Console.WriteLine(myvar);
            Console.ReadLine();
        }
    }
}