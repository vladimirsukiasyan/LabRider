using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Department
    {
        public int ID;
        public string Name;

        public Department(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("{{ Department ID: {0}, Name: {1} }}", ID, Name);
        }
    }
}
