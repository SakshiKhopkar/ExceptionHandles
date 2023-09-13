using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandles
{
    //2.WAP to check String content only alphabets if any digit or symbol is present then throw custom exception
    public class DigitOrSymbolException : Exception
    {
        public DigitOrSymbolException(string error) : base(error)
        {

        }
    }
    public class User
    {
        public User(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i]>='a'&& str[i]<='z') || (str[i]>='A' && str[i] <= 'Z'))
                {
                    string str1=null;
                }
                else
                {
                    throw new DigitOrSymbolException("you have enter the symbol Or Digit");
                    break;
                }
            }
        }
    }
    public class DigitOrSymbolExceptionRun
    {
        static void Main(string[] args)
        {
            try
            {
                User u1 = new User("sa$shi");
            }
            catch(DigitOrSymbolException e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
