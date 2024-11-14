using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day7
{
    class VotingException : ApplicationException
    {
        public VotingException(string Message) : base(Message)
        {

        }
    }

    public class Vote
    {
        public void AcceptAge()
        {
            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age <= 18)
            {
                throw (new VotingException("Age should be greater than 18"));
            }
            else
            {
                Console.WriteLine("Eligible");
            }
        }
    }


    class UserDefined_Exception
    {
        public static void Main()
        {
            Console.WriteLine(" Checked Output : {0} ", OverFlowExample.CheckOverFlow());
            Console.WriteLine("=======================================================");
            Console.WriteLine("UnChecked Output : {0} ", OverFlowExample.UnCheckOverflow());
            //try
            //{

            //    //Vote v1 = new Vote();
            //    //v1.AcceptAge();
            //}

            //catch (VotingException ve)
            //{

            //    //Console.WriteLine(ve.Message);
            //    //Console.WriteLine(ve.StackTrace);
            //}
            Console.Read();
        }
    }

    class OverFlowExample
    {
        static int maxint = 2147483647;

        //checked expression
        public static int CheckOverFlow()
        {
            int x = 0;
            try
            {
                x = checked(maxint + 10); // this line raises an exception
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("Checked : " + oe.ToString());
            }
            return x;
        }

        public static int UnCheckOverflow()
        {
            int maxint1 = 2147483647;
            int y = 0;
            try
            {
                y = unchecked(maxint1 + 10);
            }
            catch (OverflowException oz)
            {
                Console.WriteLine("Unchecked " + oz.ToString());
            }

            finally
            {
                Console.WriteLine("Reached Finally");
            }
            return 0;
           
            //Overflow is supressed

            
        }
    }
}
