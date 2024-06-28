using System.ComponentModel.DataAnnotations;

namespace WebApplication_MVC_task1.Models
{
	public class Category
	{
		public int Id { get; set; }
		[MaxLength(30)]
		public string Name { get; set; } = null!;
		public DateTime CreatedOn { get; set; } = DateTime.Now;
		public DateTime UpdatedOn { get; set; } = DateTime.Now;

	}
}
