using MeridianConsoleApp1.Models.Entity;
using MeridianConsoleApp1.Models.Enums;
using MeridianTestAssigment2.Models.Enums;

namespace MeridianTestAssigment2.Models.Entity
{
    public class Department : BaseClass
    {
        public City City { get; set; }
        public decimal Coefficient { get; set; } // Коэффициент зп
        public DepartmentType DepartmentType { get; set; } // Типы отделов

    }
}