using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	[EnableCors]
	public class EmpController : ControllerBase
	{
		[HttpGet]
        public List<Empdot> GetEmps()
		{
			List<Empdot> list = new List<Empdot>();
			using (var db = new knowitContext())
			{
				list = db.Empdots.ToList();
			}
			return list;
		}

		[HttpGet]
		public Empdot? GetEmp(int Eno)
		{
			Empdot? emp = new Empdot();
			using (var db = new knowitContext())
			{
				emp = db.Empdots.Find(Eno);
			}
			return emp;
		}

		[HttpPost]
		public string SaveEmp(Empdot emp)
		{
			using (var db = new knowitContext())
			{
				db.Empdots.Add(emp);
				db.SaveChanges();//save changes into database
			}
			return "Emp saved Successfully!";
		}

		[HttpDelete]
		public string DeleteEmp(int Eno)
		{
			Empdot? emp = new Empdot();
			using (var db = new knowitContext())
			{
				emp = db.Empdots.Find(Eno);
				db.Empdots.Remove(emp);
				db.SaveChanges();
			}
			return "Emp Deleted Successfully";
		}

		[HttpPost]
		public string UpdateEmp(Empdot emp)
		{
			Empdot? em = new Empdot();
			using (var db = new knowitContext())
			{
				em = db.Empdots.Find(emp.Eno);
				em.Ename = emp.Ename;
				em.Job = emp.Job;
				em.Sal = emp.Sal;
			
				db.SaveChanges();
			}
			return "Emp Updated Successfully!";
		}
	}
}
