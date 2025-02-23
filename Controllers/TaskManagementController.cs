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
            return View(tasks);
		}

		public IActionResult CreateTask()
		{
			var tasks = _dbContext.Tasks.ToList();
			return View(tasks);
		}

		[HttpPost]
		public async Task<IActionResult> CreateTask(TaskManagement task)
		{
			if(ModelState.IsValid)
			{
				_dbContext.Tasks.Add(task);
				await _dbContext.SaveChangesAsync();

                var tasks = _dbContext.Tasks.ToList();
                return View(tasks);
			}

            var existingTasks = _dbContext.Tasks.ToList();
            return View(existingTasks);
		}

		
	}
}
