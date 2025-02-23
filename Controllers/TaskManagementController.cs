using Microsoft.AspNetCore.Mvc;

namespace TaskManagmentApp.Controllers
{
	public class TaskManagementController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult CreateTask()
		{
			return View();
		}
	}
}
