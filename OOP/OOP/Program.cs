using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Person
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.Name = name;
            }
        }
        private int aldre;
        public int Aldre
        {
            get
            {
                return aldre;
            }
            set
            {
                this.Aldre = aldre;
            }
        }
    }
    class City
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {

            }
        }
    }
}
