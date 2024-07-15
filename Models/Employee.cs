using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication_MVC_task1.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Title { get; set; } = null!;
		public int Age { get; set; }
	}
}
