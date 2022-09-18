﻿using RazorPagesTutorial.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesTutorial.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Marry", Department = Dept.HR, Email = "marry@pragimtech.com", PhotoPath = "mary.png" },
                new Employee() { Id = 2, Name = "John", Department = Dept.IT, Email = "john@pragimtech.com", PhotoPath = "john.png" },
                new Employee() { Id = 3, Name = "Sara", Department = Dept.IT, Email = "sara@pragimtech.com", PhotoPath = "sara.png" },
                new Employee() { Id = 4, Name = "David", Department = Dept.Payroll, Email = "david@pragimtech.com" }
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }
    }
}
