using day5c_;

namespace day5c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Department dept = new Department { DeptID = 1, DeptName = "Sales" };
            Club club = new Club { ClubID = 1, ClubName = "Corporate Club" };

            Employee emp1 = new Employee { EmployeeID = 1, BirthDate = new DateTime(1960, 1, 1), VacationStock = 5 };
            SalesPerson sp = new SalesPerson { EmployeeID = 2, AchievedTarget = 50 };
            BoardMember bm = new BoardMember { EmployeeID = 3, BirthDate = new DateTime(1950, 1, 1) };

            dept.AddStaff(emp1);
            dept.AddStaff(sp);
            dept.AddStaff(bm);

            club.AddMember(emp1);
            club.AddMember(sp);
            club.AddMember(bm);

            emp1.VacationStock = -1;
            sp.CheckTarget(100);    
            bm.Resign();
            Console.WriteLine(emp1);
            Console.WriteLine("========================================================================\n");
            Console.WriteLine(club);
        }
    }
}