using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5c_
{
    class Club
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }
        private List<Employee> Members = new List<Employee>();

        public void AddMember(Employee e)
        {
            Members.Add(e);
            e.EmployeeLayOff += RemoveMember;
        }

        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.VacationStockNegative)
            {
                Members.Remove((Employee)sender);
            }
        }
        public override string ToString()
        {
            string str = $"Club ID : {ClubID}\nname :{ClubName}";
            foreach (Employee e in Members)
            {
                str += "\n////////////////\n" + e.ToString();
            }
            return str;
        }
    }
}
