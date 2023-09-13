using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandles
{
    public class NameException : Exception
    {
        public NameException(string error):base(error) 
        { 

        }
    }
    public class Student
    {
        public Student(string name)
        {
           if(string.IsNullOrEmpty(name))
           {
                throw new NameException("string is empty");
           }
        }
            

    }

    internal class RunNameExeception
    {
        static void Main(string[] args)
        {
            try
            {
                Student s1 = new Student("");
            }
            catch (NameException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
