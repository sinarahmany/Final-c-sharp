using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_24May
{
    class Student : Person, IUpdatable
    {
        public string Program { set; get; }
        public DateTime Start_Date { get; set; }
        public DateTime Update_Date { get; set; }
        public Dictionary<string,bool> Skillset { get; set; }

    public Student() : base()
        {
            Skillset = new Dictionary<string, bool>();
            Program = "n";
            Start_Date = new DateTime();
            Update_Date = new DateTime();
        }

        public Student(string Name, string LastName, string Email, string Program)
        {
            this.Name = Name;
            this.Last_Name = LastName;
            this.Email = Email;
        }
        
        //overriding the greeting file in the greeting in person class
    public override void Greeting()
        {

            //base.Greeting();
            Console.Write($"Hello i am {Name}  "  );
            Console.WriteLine(Last_Name);
            Console.WriteLine($"My email is :{Email}");
            
            Console.Write($"I have started {Program} at ");
            Console.WriteLine($"{Start_Date}in ITD Canada I am able to develop code in the following programming languages");
            //check if the skill is true print it else skip
            foreach (KeyValuePair<string, bool> skill in Skillset)
            {

                var Key = skill.Key;
                var Value = skill.Value;

                if (Value)
                {
                    Console.Write(Key.ToString() + ", ");

                }


            }
        }
        
    }
        
    
}
