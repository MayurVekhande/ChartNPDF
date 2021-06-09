using DemoProject.IRepository;
using DemoProject.Models;
using DemoProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rotativa;
namespace DemoProject.Controllers
{
    [HandleError(View = "Error")]
    public class EmployeeController : Controller
    {
        private IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository _employeeRepository)
        {
            this.employeeRepository = _employeeRepository;
        }
        // GET: Employee
        public ActionResult GetAllEmployee()
        {
            return View(employeeRepository.GetAllEmployee().ToList());
        }

        [AllowAnonymous]
        public ActionResult Print()
        {
            var pdf = new ActionAsPdf("GetAllEmployee");                       
            return pdf;
        }
    }
}