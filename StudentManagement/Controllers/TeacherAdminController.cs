using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
	public class TeacherAdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

	}
}
