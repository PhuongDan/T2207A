using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
namespace T2207A_VSCode
{
    public class Student
    {
        public string name;
        public string email;
        public int age;
        public string telephone;

        public Student()
        {
            this.Run();
            Learn();
        }

        public Student(string name, string email, int age, string telephone)
        {
            this.name = name;
            this.email = email;
            this.age = age;
            this.telephone = telephone;
        }

        public string Name // property
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int Age
        {
            get => this.age;
            set => this.age = value;
        }

        public string Telephone
        {
            get => this.telephone;
            set => this.telephone = value;
        }

        public virtual void Run()
        {
            Console.WriteLine(this.name + "Running...");
        }

        public void Learn()
        {
            Console.WriteLine("Learning...");
        }
        public void Learn(string s)
        {
            Console.WriteLine("Learning..." + s);
        }
    }
}
