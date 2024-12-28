using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5c_
{
    class BoardMember : Employee
    {
        public BoardMember()
        {
            BirthDate = new DateTime(1900, 1, 1);
        }

        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.Resigned });
        }

        public override int VacationStock
        {
            get => 0; 
            set { }   
        }

        public override DateTime BirthDate
        {
            get => base.BirthDate;
            set { } 
        }
    }
}
