using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeridianConsoleApp1.Models.Entity;
using MeridianConsoleApp1.Models.Enums;
using MeridianTestAssigment2.Models.Entity;
using MeridianTestAssigment2.Models.Enums;

namespace MeridianTestAssigment2.Services
{
    internal static class DepartmentService
    {
        private static readonly Dictionary<DepartmentType, double> _coefficients = new Dictionary<DepartmentType, double>()
        {
            { DepartmentType.Purchasing, 1.3 },
            { DepartmentType.Sales, 1.47 },
            { DepartmentType.Finance, 1.67 }
        };

        public static List<Department> GetDepartments() => new List<Department>();

        public static List<Department> GetDepartments(City city)
        {
            return GetDepartments().Where(department => department.City == city).ToList();
        }

        /*
        Компания "Стар" имеет в Москве, Питере и Ростове филиалы, где в каждом городе есть отделы Закупок, Продаж и Финансов.  
        Коэффициент зп для отдела Закупок 1.3, для Продажи 1.47, для Финансы 1.67.  
        Мин зп = 18500.  
        Зп сотрудника рассчитать по формуле 
        Мин зп * Коэффициент зп + опты работы * ( если кол-во сотрудников (в городе) > 50 тогда * 16000, если > 20 и <= 50 тогда * 12000, если <= 20 тогда * 9000) 
    

        Если нужны доработки в классах можно сделать */

        public static double CalculateSalary(Department department)
        {
            var employeeList = EmployerService.GetEmployers(department);

            var employersCount = EmployerService.GetEmployersCount(department.City);
            // не знаю как правильно назвать этот коэффициент ( если кол-во сотрудников (в городе) > 50 тогда * 16000, если > 20 и <= 50 тогда * 12000, если <= 20 тогда * 9000)
            var lastCoefficient = employersCount > 50 ? 16000 : (employersCount > 20 ? 12000 : 9000);

            var salary = double.MinValue;

            foreach (var employee in employeeList)
            {
                salary += Employer.MinSalary * _coefficients[department.DepartmentType] + employee.WorkExperience * lastCoefficient;
            }

            return salary;
        }


    }
}
