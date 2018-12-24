using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class A
    {
        public int PropertyInt { get; set; }
        public double PropertyDouble { get; set; }
        public string PropertyString { get; set; }

        public A(int propertyInt, double propertyDouble, string propertyString)
        {
            PropertyInt = propertyInt;
            PropertyDouble = propertyDouble;
            PropertyString = propertyString;
        }

        public int MethodInt()
        {
            return 10;
        }

        public double MethodDouble()
        {
            return 10.10;
        }

        public string MethodString()
        {
            return "10";
        }
    }
}
