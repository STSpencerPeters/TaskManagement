using System.ComponentModel.DataAnnotations;

namespace TaskManagmentApp.Models
{
	public class TaskManagement
	{
		[Key]
		public int TaskID {  get; set; }

		[Required]
		public string TaskName { get; set; }

		[Required]
		public string TaskDescription { get; set; }

		public bool IsCompleted { get; set; }
	}
}
