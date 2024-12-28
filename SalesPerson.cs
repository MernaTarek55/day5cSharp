using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5c_
{
    class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }

        public bool CheckTarget(int quota)
        {
            if (AchievedTarget < quota)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.FailedToAchieveTarget });
                return false;
            }
            return true;
        }

        public override int VacationStock
        {
            get => 0; 
            set { }  
        }
    }
}
