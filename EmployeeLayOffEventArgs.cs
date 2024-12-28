using System;

namespace day5c_
{

    public enum LayOffCause
    {
        VacationStockNegative,
        AgeAboveSixty,
        FailedToAchieveTarget,
        Resigned
    }
    public class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause Cause { get; set; } 
    }
}
