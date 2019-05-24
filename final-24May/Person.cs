using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_24May
{
    //the abstract class that 
    public abstract class Person
    {
        public string Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        //deafult constractor
        public Person()
        {
            Name = "Alaska";
            Last_Name = "Doody";
            Email = "unknown";
        }
        //virtual fuction for greeting 
        public virtual void Greeting()
    {
            Console.WriteLine(Name);
            Console.WriteLine(Last_Name);
            Console.WriteLine(Email);
        }
    }
}
