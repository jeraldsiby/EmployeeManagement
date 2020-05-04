using System;
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
                new Employee() { Id =2, Name = "Sooraj",Email ="soo@gmail.com", Department = Dept.HR },
                new Employee() { Id =3, Name = "Nithin",Email ="nith@gmail.com", Department = Dept.Payroll }
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id)+1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee emp = _employeeList.FirstOrDefault(e => e.Id == id);
            if (emp != null)
            {
                _employeeList.Remove(emp);
            }
            return emp;
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

        public Employee Update(Employee employeeChanges)
        {
            Employee emp = _employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (emp != null)
            {
                emp.Name = employeeChanges.Name;
                emp.Email = employeeChanges.Email;
                emp.Department = employeeChanges.Department;
            }
            return emp;
        }
    } 
}
