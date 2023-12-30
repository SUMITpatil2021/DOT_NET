using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DisplayStudent(int sid,string sname,int age,float marks)
        {
            Student student = new Student() { Id = sid, Name = sname, Age = age, Marks = marks };

            return View(student);
        }
    }
}
