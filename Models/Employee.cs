using System.ComponentModel.DataAnnotations;

namespace WebApplication_MVC_task1.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Title { get; set; } 
		public int Age { get; set; }
	}
}
