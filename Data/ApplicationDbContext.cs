using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication_MVC_task1.Models;
using WebApplication_MVCProject.Models;

namespace WebApplication_MVC_task1.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public DbSet<Category> Categories { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Author> Authors { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<BookCategory> BookCategories { get; set; }


		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<BookCategory>().HasKey(e => new
			{
				e.CategoryId,
				e.BookId
			});
			base.OnModelCreating(builder);
		}
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
	}
}
