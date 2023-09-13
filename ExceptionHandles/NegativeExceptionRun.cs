using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandles
{
    //1.If number is negative then throw negative number exception.
    public class NegativeException : Exception
    {
        public NegativeException(string error) : base(error)
        {

        }
    }
    public class user
    {

        public user(int no)
        {
            if (no < 0)
            {
                throw new NegativeException("number is negative");
            }
            if (no == 0)
            {
                throw new NegativeException("number is zero");
            }
        }
        public class NegativeExceptionRun
        {
            static void Main(string[] args)
            {
                try
                {
                    user u1 = new user(-1);
                    
                }
                catch(NegativeException e)
                {
                    Console.WriteLine(e.Message);
                }
                try
                {
                    user u2 = new user(0);
                }
                catch (NegativeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
