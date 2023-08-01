using System;
using ClasssWorkCollections.Models;
using ClasssWorkCollections.Services.Interfaces;

namespace ClasssWorkCollections.Services
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> FilterBySalary(decimal firstsalary, decimal secondSalary, List<Employee> employees)
        {
            return employees.FindAll(m => m.Salary > firstsalary && m.Salary < secondSalary);
        }

        public List<Employee> GetAll()
        {
            List<Employee> list = new List<Employee>();

            list.Add(new Employee() { Id = 1, FullName = "Ismail Efendizade", Age = 29, Salary = 2000 });
            list.Add(new Employee() { Id = 2, FullName = "Samir Qehremenov", Age = 25, Salary = 2500 });
            list.Add(new Employee() { Id = 3, FullName = "Fidan Bashirova", Age = 22, Salary = 3000 });
            list.Add(new Employee() { Id = 4, FullName = "Kubra Memmedova", Age = 25, Salary = 2400 });
            list.Add(new Employee() { Id = 5, FullName = "Pervin Mirzeyev", Age = 30, Salary = 4500 });

            return list;
        }
    }
}

