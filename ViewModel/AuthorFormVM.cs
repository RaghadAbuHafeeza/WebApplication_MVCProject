using System.ComponentModel.DataAnnotations;

namespace WebApplication_MVCProject.ViewModel
{
	public class AuthorFormVM
	{
		public int Id { get; set; }
		[MaxLength(50, ErrorMessage = "The Nme Field Can't Exceed 50 Characters")]
		public string Name { get; set; }
	}
}
