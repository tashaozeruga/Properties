using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Man
    {
        private string name;
        public string Name 
        {
            set
            {
                if (value != "") name = value;
            }
            get
            {
                return name;
            }
            
           }
        int age;

        public int Age
        {
            set
            {
                if (value > 0 && value < 100) 
                age = value;
            }
            get
            {
                return age;
            }
        }
        public Man(string name, int age)
        {
            Name = name;
            this.age = age;

        }
         
         
    }
}
