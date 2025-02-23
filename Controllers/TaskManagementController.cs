using Microsoft.AspNetCore.Mvc;
using TaskManagmentApp.Models;

namespace TaskManagmentApp.Controllers
{
	public class TaskManagementController : Controller
	{
		private readonly TaskDbContext _dbContext;

		public TaskManagementController(TaskDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public IActionResult Index()
		{
            var tasks = _dbContext.Tasks.ToList();
            return View();
		}

		public IActionResult CreateTask()
		{
			var tasks = _dbContext.Tasks.ToList();
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateTask(TaskManagement task)
		{
			if(ModelState.IsValid)
			{
				_dbContext.Tasks.Add(task);
				await _dbContext.SaveChangesAsync();
				return RedirectToAction("CreateTask");
			}

			return View("CreateTask", _dbContext.Tasks.ToList());
		}
	}
}
