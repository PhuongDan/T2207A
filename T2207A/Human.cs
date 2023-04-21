using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class Human
    {
        private DateTime birthday;
        public string[] family = new string[3];
        public string this[int index]
        {
            get => family[index];
            set => family[index] = value;
        }
        public DateTime Birthday
        {
            get => birthday;
            set => birthday = value;
        }
        //abstract property
        public string Telephone
        {
            get;
            set;
        }

    }
}
