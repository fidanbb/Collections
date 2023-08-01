using System;
using ClasssWorkCollections.Models;

namespace ClasssWorkCollections.Services.Interfaces
{
	public interface IEmployeeService
	{
		List<Employee> GetAll();
		List<Employee> FilterBySalary(decimal firstsalary,decimal secondSalary,List<Employee> employees);
	}
}

