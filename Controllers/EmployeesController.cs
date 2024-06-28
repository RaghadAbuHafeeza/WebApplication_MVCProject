using Microsoft.AspNetCore.Mvc;
using WebApplication_MVC_task1.Data;
using WebApplication_MVC_task1.Models;

namespace WebApplication_MVC_task1.Controllers
{
	public class EmployeesController : Controller
	{
		private readonly ApplicationDbContext context;

		public EmployeesController(ApplicationDbContext context)
		{
			this.context = context;
		}
		public IActionResult Index()
		{
			var employees = new List<Employee>
			{
				new Employee { Id = 1, Name = "Ahmad", Title = "Manager", Age = 45 },
				new Employee { Id = 2, Name = "Raghad", Title = "Engineer", Age = 30 },
				new Employee { Id = 3, Name = "Tala", Title = "Accounting", Age = 28 }
			}; return View(employees);
		}
	}
}
