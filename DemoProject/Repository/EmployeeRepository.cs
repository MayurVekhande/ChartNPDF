using DemoProject.IRepository;
using DemoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoProject.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private DemoProjectEntities DemoProjectEntities;

        public EmployeeRepository()
        {
            DemoProjectEntities = new DemoProjectEntities();
        }
        public IEnumerable<Employee> GetAllEmployee()
        {
            return DemoProjectEntities.Employees.ToList();            
        }
    }
}