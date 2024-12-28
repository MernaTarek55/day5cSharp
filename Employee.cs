using System;

namespace day5c_
{
    class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }
        
        public int EmployeeID { get; set; }

        private DateTime birthDate;
        public virtual DateTime BirthDate
        {
            get => birthDate;
            set => birthDate = value; 
        }

        private int vacationStock;
        public virtual int VacationStock
        {
            get => vacationStock;
            set
            {
                vacationStock = value;
                if (vacationStock < 0)
                {
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.VacationStockNegative });
                }
            }
        }

        public bool RequestVacation(DateTime from, DateTime to)
        {
            int requestedDays = (to - from).Days;
            if (VacationStock >= requestedDays)
            {
                VacationStock -= requestedDays;
                return true;
            }
            return false;
        }

        public void EndOfYearOperation()
        {
            int age = 2024 - BirthDate.Year;
            //if (BirthDate > DateTime.Now.AddYears(-age)) age--;
            if (age > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.AgeAboveSixty });
            }
        }
        public override string ToString()
        {
            return $"Employee ID : {EmployeeID}\nBirth Date : {BirthDate}\nVacation Stock : {VacationStock}\n ";
        }
    }
}
