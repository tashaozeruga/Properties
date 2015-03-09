using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Man m1 = new Man("Alex", 30);
            Man m2 = new Man("Peter", 25);

            m1.Name = "Vasya";
            m2.Name = "";


            m1.Age = 5;
            m2.Age -= 30;

            Console.WriteLine(m1.Name + ": " + m1.Age);
            Console.WriteLine(m2.Name + ": " + m2.Age);



        }
    }
}
