using Microsoft.AspNetCore.Mvc;

namespace WebAPP_EF.Controllers
{
	public class EmpController : Controller
	{
		public IActionResult EmpList()
		{
			return View();
		}
	}
}
