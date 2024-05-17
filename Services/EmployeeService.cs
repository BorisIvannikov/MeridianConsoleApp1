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
    internal static class EmployerService
    {
        public static List<Employer> GetEmployers() => new List<Employer>();

        /// <summary>
        /// Возвращает сотрудников этого отдела, соответсвенно и этого города и этого типа отдела
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public static List<Employer> GetEmployers(Department department) => GetEmployers().Where(employer => employer.Department == department).ToList();
        public static int GetEmployersCount(City city) => GetEmployers().Where(employer => employer.Department.City == city).Count();

        public static int GetEmployersCount(City city, DepartmentType department)
        {
            var employeeList = GetEmployers().Where(employer => employer.Department.City == city && employer.Department.DepartmentType == department);
            
            return employeeList.Count();
        }


    }
}
