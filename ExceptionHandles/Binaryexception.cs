using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandles
{
    //10.WAP to check number is binary or not if not then throw Exception else convert into decimal.
    public class Binaryexception:Exception
    {
      public Binaryexception(string error):base(error) 
      { 
    
      }
    }
    public class UserEnter
    {
        public UserEnter(string bin)
        {
            bool iseual=false;
            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i] != '0' && bin[i] != '1')
                {
                    throw new Binaryexception("not binary");
                    break;

                }
                else
                {
                    iseual = true;
                }
            }
            int decimalValue = 0;
            int binaryBase = 2;
            int exponent = 0;
            if (iseual)
            {
                for (int j = bin.Length-1; j>=0; j--)
                {
                    if (bin[j] == '1')
                    {
                        decimalValue += (int)Math.Pow(binaryBase, exponent);
                    }
                    exponent++;
                }  
            }
            Console.WriteLine(decimalValue);
        }
    }
    public class RunBinaryExecption
    {
        static void Main(string[] args)
        {
            try
            {
                UserEnter u1 = new UserEnter("11678");
            }
            catch (Binaryexception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
