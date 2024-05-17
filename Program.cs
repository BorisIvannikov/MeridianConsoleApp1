using MeridianConsoleApp1.Models.Enums;
using MeridianTestAssigment2.Models.Enums;
using MeridianTestAssigment2.Services;

namespace MeridianConsoleApp1
{
    internal class Program
    {
        public void Main(string[] args)
        {
            CompleteTestAssignment();
        }

        private void CompleteTestAssignment()
        {
            /*
            Компания "Стар" имеет в Москве, Питере и Ростове филиалы, где в каждом городе есть отделы Закупок, Продаж и Финансов.  
            Коэффициент зп для отдела Закупок 1.3, для Продажи 1.47, для Финансы 1.67.  
            Мин зп = 18500.  
            Зп сотрудника рассчитать по формуле 
            Мин зп * Коэффициент зп + опты работы * ( если кол-во сотрудников (в городе) > 50 тогда * 16000, если > 20 и <= 50 тогда * 12000, если <= 20 тогда * 9000) 
	    // Если нужны доработки в классах можно сделать

            1. Сколько всего человек работает в отделе Закупок в Москве? */

            int implodesInMoscow = EmployerService.GetEmployersCount(City.Moscow, DepartmentType.Purchasing);

            /*
            2. Рассчитать ежемесячную зп на всех сотрудников по городам и отделам. 
            Показать в формате: 
            Москва 90000тыс = Продажа 30000тыс, Закупка 30000тыс, Финансы 30000тыс.
            */

            string totalSalaryMoscow = CityService.GenerateReportSalary(City.Moscow);
            string totalSalarySanktPeterburg = CityService.GenerateReportSalary(City.SanktPeterburg);
            string totalSalaryRostovOnDon = CityService.GenerateReportSalary(City.RostovOnDon);
        }
    }
}