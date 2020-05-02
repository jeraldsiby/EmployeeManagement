﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id =1, Name = "Jerald",Email ="jer@gmail.com", Department = Dept.IT },
                new Employee() { Id =2, Name = "Sooraj",Email ="soo@gmail.com", Department = Dept.HR }
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            //var emp = from Employee in _employeeList
            //          where Employee.Id == id
            //          select Employee;
            //return emp.FirstOrDefault();
            return _employeeList.FirstOrDefault(emp => emp.Id == id);
        }
    } 
}
