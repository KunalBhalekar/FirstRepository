using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entitycrud
{
    class Program
    {
        static void Main(string[] args)
        {
          
            StudentContext context = new StudentContext();

            Student s2 = context.Students.Find(1);
            Console.WriteLine(s2.Name);
            Console.ReadLine();

         
           
        }
    }
}
