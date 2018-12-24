﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Employee
    {
        public int ID;
        public string Surname;
        public int DepartmentID;

        public Employee(int id, string surname, int departmentId)
        {
            ID = id;
            Surname = surname;
            DepartmentID = departmentId;
        }

        public override string ToString()
        {
            return string.Format("{{ Employee ID: {0}, Surname: {1}, DepartmentID: {2} }}", ID, Surname, DepartmentID);
        }
    }
}
