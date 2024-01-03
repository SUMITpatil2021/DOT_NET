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
        [HttpGet]
        public IActionResult AddEmp() {
        return View();
        }

        [HttpPost]
        public IActionResult AddEmp(Employee emp)
        {
           
                EmpDAL empDAL = new EmpDAL();
                int res = empDAL.InsertEmp(emp);
                if (res > 0)
                {
                    return RedirectToAction("EmpList");
                }
                else
                {
                    return Content("Could Not Save !!! Plz try again ");
                }
           
        }


        public IActionResult UpdateEmp() {
            EmpDAL empDAL = new EmpDAL();
			Employee emp = empDAL.GetEmp(id);
			return View();
        }
        public IActionResult DeleteEmp()
        { 
            return View();  
        }


    }
}
