using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace final_24May
{
    class Program
    {
        static void Main(string[] args)
        {
        //calling the function to print the final part
        Student st1 = new Student();
            
            showStudents(GetStudents("http://www.json-generator.com/api/json/get/bPCtVMPmNu?indent=01"), "ITD General programming 2019");
        }

        //calling jason and create a web client to download the url below and convert it
        public static List<Student> GetStudents(string students)
        {
            WebClient jasonObj = new WebClient();
            string Result = jasonObj.DownloadString(students);
            List<Student> list = JsonConvert.DeserializeObject<List<Student>>(Result);
            return list;

        }

        //create a list cause the jason file is a list of students
        public static void showStudents(List<Student> students, string name)
        {
            Console.WriteLine($"-----------------{name}-----------------");


            foreach (var student in students)
            {
                student.Greeting();
                Console.Write("\n\n");
            }

        }
    }

}

