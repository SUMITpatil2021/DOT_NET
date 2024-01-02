using System.ComponentModel.DataAnnotations;

namespace CURD_Operation_EMP.Models
{
	public class Employee
	{
		[Required (ErrorMessage ="Eno is required ")]
		public int? eno { get; set; }
		[Required (ErrorMessage ="Ename is required ")]
		public string ename { get; set; }

		[Required (ErrorMessage ="Job Is required ")]
		public string job { get; set; }
		[Required (ErrorMessage ="Salary is required ")]
		[Range (0,9999,ErrorMessage ="salary must be in range  0 to 9999")]
		public float? sal { get; set; }
	}
}
