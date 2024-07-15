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
            var employees = context.Employees.ToList();
            return View(employees);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
