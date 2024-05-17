using MeridianTestAssigment2.Models.Entity;

namespace MeridianConsoleApp1.Models.Entity
{
    public class Employer : BaseClass
    {
        public static double MinSalary => 18500;
        public long DepartmentId { get; set; }
        public int WorkExperience { get; set; } // Опыт работы

        public Department Department { get; set; }

        public double Salary { get; set; }


    }
}