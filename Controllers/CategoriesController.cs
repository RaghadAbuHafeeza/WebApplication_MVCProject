using Microsoft.AspNetCore.Mvc;
using WebApplication_MVC_task1.Data;

namespace WebApplication_MVC_task1.Controllers
{
	public class CategoriesController : Controller
	{
		private readonly ApplicationDbContext context;

		public CategoriesController(ApplicationDbContext context)
		{
			this.context = context;
		}

		public IActionResult Index()
		{
			var categories = context.Categories.ToList();
			return View(categories);
		}
	}
}
