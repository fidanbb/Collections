using System;
using ClasssWorkCollections.Models;
using ClasssWorkCollections.Services;
using ClasssWorkCollections.Services.Interfaces;

namespace ClasssWorkCollections.Controller
{
	public class EmployeeController
	{
		private readonly IEmployeeService _employeeService;

		public EmployeeController()
		{
			_employeeService = new EmployeeService();
		}
		public void GetAll()
		{
			var employees = _employeeService.GetAll();

			foreach (var employee in employees)
			{
				string result = $"{employee.Id}- {employee.FullName} - {employee.Age} - {employee.Salary}";
				Console.WriteLine(result);
			}
		}


		public void FilterBySalary()
		{
			decimal first = 2400;
			decimal second = 4000;

			List<Employee> employees = _employeeService.GetAll();

			var filteredEmployess = _employeeService.FilterBySalary(first,second,employees);


			foreach (var employee in filteredEmployess)
			{
                string result = $"{employee.Id}- {employee.FullName} - {employee.Age} - {employee.Salary}";
                Console.WriteLine(result);
            }
		}
	}
}

