using Microsoft.EntityFrameworkCore;
using TaskManagmentApp.Models;


public class TaskDbContext : DbContext
	{
		public TaskDbContext(DbContextOptions<TaskDbContext> options)
		: base(options) { }

		public DbSet<TaskManagement> Tasks { get; set; }
	}
