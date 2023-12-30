using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmpController : Controller
    {
        [HttpGet]
        public IActionResult Index() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult DisplayEmp(int id,string ename,string job,float sal) 
        {
            Employee employee = new Employee() {  Id=id, Name=ename, Job= job, salary= sal };  
            return View(employee);

        }
    }
}
