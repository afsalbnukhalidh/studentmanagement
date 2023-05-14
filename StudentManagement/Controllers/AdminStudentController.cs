using Microsoft.AspNetCore.Mvc;
using StudentManagement.Data;

namespace StudentManagement.Controllers
{
	public class AdminStudentController : Controller
	{
		private readonly StudentManagementDbContext studentManagementDbContext;

		public AdminStudentController(StudentManagementDbContext studentManagementDbContext)
        {
			this.studentManagementDbContext = studentManagementDbContext;
		}
		public async Task<IActionResult> CreateStudent()
		{
			return View();
		}
    }
}
