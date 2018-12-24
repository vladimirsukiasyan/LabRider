using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class DepartmentEmployees
    {
        public int EmployeeID;
        public int DepartmentID;

        public DepartmentEmployees(int employeeId, int departmentId)
        {
            EmployeeID = employeeId;
            DepartmentID = departmentId;
        }

        public override string ToString()
        {
            return string.Format("{{ DepartmentEmployees EmployeeID: {0}, DepartmentID: {1} }}", EmployeeID, DepartmentID);
        }
    }
}
