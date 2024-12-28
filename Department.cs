using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5c_
{
    class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        private List<Employee> Staff = new List<Employee>();

        public void AddStaff(Employee e)
        {
            Staff.Add(e);
            e.EmployeeLayOff += RemoveStaff;
        }

        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.VacationStockNegative || e.Cause == LayOffCause.AgeAboveSixty)
            {
                Staff.Remove((Employee)sender);
            }
        }
    }
}
