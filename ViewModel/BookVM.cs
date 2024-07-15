using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_MVCProject.ViewModel
{
	public class BookVM
	{
		public int Id { get; set; }
		public string Title { get; set; } = null!;
		public string Author { get; set; }
		public string Publisher { get; set; } = null!;
		public DateTime PublishDate { get; set; }
		public string ImageUrl { get; set; }
		public List<string> Categories { get; set; }
	}
}
