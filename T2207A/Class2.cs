using System;
namespace T2207A_VSCode
{
    public class FPT_Student : Student
    {
        private string className;

        public FPT_Student() : base()
        {
            this.Name = "Nghiadz";
        }

        public FPT_Student(string name, string email, int age, string telephone, string className) : base(name, email, age, telephone)
        {
            this.className = className;
        }

        public override void Run()
        {
            base.Learn();
        }

        public new void Learn() // khi khong co virtual ma van phai override
        {

        }
    }
}
