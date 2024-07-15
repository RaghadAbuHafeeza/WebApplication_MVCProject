using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_MVCProject.ViewModel
{
	public class AuthorVM
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "plz inter name")]
		[MaxLength(30, ErrorMessage = "30")]
		[Remote("CheckName", null, ErrorMessage = "exists")]
		public string Name { get; set; }
		public DateTime CreatedOn { get; set; } = DateTime.Now;
		public DateTime UpdatedOn { get; set; } = DateTime.Now;
	}
}
