using CURD_Operation_EMP.DAL;
using CURD_Operation_EMP.Models;
using Microsoft.AspNetCore.Mvc;

namespace CURD_Operation_EMP.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult EmpList()
        {
            EmpDAL empDAL = new EmpDAL();
            List<Employee> emps = empDAL.GetEmpList();
            return View(emps);
        }

        public IActionResult AddEmp() {
        return View();
        }

        public IActionResult UpdateEmp() {
            return View();
        }
        public IActionResult DeleteEmp()
        { 
            return View();  
        }


    }
}
