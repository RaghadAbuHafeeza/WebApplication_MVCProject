using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication_MVC_task1.Models;

namespace WebApplication_MVC_task1.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public DbSet<Category> Categories { get; set; }
		public DbSet<Employee> Employees { get; set; }


		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
	}
}
