using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schools
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Ovveride ToString()
        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
