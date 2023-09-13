using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name ");
            try
            {
                string name = Console.ReadLine();
                //string name = null;
                
                if(string.IsNullOrEmpty(name))
                {
                    throw new Exception("Name is required");
                }
                Console.WriteLine(name);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);

            }
            finally { Console.WriteLine("Inside finally block"); }

        }
    }
}
