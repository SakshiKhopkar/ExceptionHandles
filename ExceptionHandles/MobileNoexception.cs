using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandles
{
     //WAP to take mobile number  in String from user 
     //a)if it is content number of digit less than 10 or more than 10
     //then throw Exception.

    public class MobileNoexception:Exception
    {
        public MobileNoexception(string error):base(error)
        { 

        }
    }
    public class User2
    {
        public User2 (string no)
        {
            for (int i = 0; i < no.Length; i++)
            {
                if (no.Length > 10 || no.Length < 10 || (no[i]>='a'&& no[i]<='z') || (no[i]>='A' && no[i]<='Z'))
                {
                    throw new MobileNoexception("Invalid No");
                }
            }
        }
    }
    public class MobileExaptionRun
    {
        static void Main(string[] args)
        {
            try
            {
                User2 u1 = new User2("7821S33601");
            }
            catch(MobileNoexception e) 
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
