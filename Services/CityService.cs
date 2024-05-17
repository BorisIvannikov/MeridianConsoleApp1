using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeridianConsoleApp1.Models.Enums;

namespace MeridianTestAssigment2.Services
{
    internal static class CityService
    {
        /// <summary>
        /// Возвращает строчку типа //Москва 90000тыс = Продажа 30000тыс, Закупка 30000тыс, Финансы 30000тыс.
        /// </summary>
        public static string GenerateReportSalary(City city)
        {
            var departments = DepartmentService.GetDepartments(city);

            StringBuilder secondPartString = new StringBuilder();
            double totalCitySalary = double.MinValue;
            foreach (var department in departments)
            {
                double departmentSalary = DepartmentService.CalculateSalary(department);
                totalCitySalary += departmentSalary;
                secondPartString.Append($"{department.DepartmentType} {departmentSalary}, ");
            }

            StringBuilder output = new StringBuilder(); 
            output.Append($"{city.ToString()} {totalCitySalary.ToString()} = ");
            output.Append(secondPartString);
            return output.ToString();
        }
    }
}
