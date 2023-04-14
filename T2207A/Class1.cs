using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class Student
    {
        public string name;
        public string email;
        public int age;
        public string telephone;
        public Student() {
            this.Run();
            this.Learn();    
        }

        public void Run()
        {
            Console.WriteLine("Running....");
        }
        public void Learn()
        {
            Console.WriteLine("Learning...");

        }
    }
}
