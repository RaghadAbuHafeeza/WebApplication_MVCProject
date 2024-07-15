using Microsoft.AspNetCore.Mvc;
using WebApplication_MVC_task1.Data;
using WebApplication_MVCProject.Models;
using WebApplication_MVCProject.ViewModel;


namespace WebApplication_MVCProject.Controllers
{
	public class AuthorsController : Controller
	{
		private readonly ApplicationDbContext context;

		public AuthorsController(ApplicationDbContext context)
		{
			this.context = context;
		}

		public IActionResult Index()
		{
			var authors = context.Authors.ToList();
            /*var authorsvm = new List<AuthorVM>();
			foreach(var author in authors)
			{
				var authorvm = new AuthorVM()
				{
					Id = author.Id,
					Name = author.Name,
					CreatedOn = author.CreatedOn,
					UpdatedOn = author.UpdatedOn,
				};
				authorsvm.Add(authorvm);
			}
			return View(authorsvm);
		}

		public IActionResult Create()
		{
			return View("Form", new AuthorFormVM());*/

            var authorsVM = authors.Select(author => new AuthorVM
            {
                Id = author.Id,
                Name = author.Name,
                CreatedOn = author.CreatedOn,
                UpdatedOn = author.UpdatedOn,
            }).ToList();


            return View(authorsVM);
        }





		[HttpPost]
		public IActionResult Create(AuthorFormVM authorFormVM)
		{
			if (!ModelState.IsValid)
			{
				return View("Form", authorFormVM);
			}
			var author = new Author()
			{
				Name = authorFormVM.Name
			};
			try
			{
				context.Authors.Add(author);
				context.SaveChanges();
				return RedirectToAction("Index");
			}
			catch
			{
				ModelState.AddModelError("Name", "Author Name Already Exists");
				return View(authorFormVM);
			}


		}

		[HttpGet]
		public IActionResult Edit(int id)
		{
			var author = context.Authors.Find(id);
			if (author is null)
			{
				Console.WriteLine($"Author with ID {id} not found.");

				return NotFound();
			}

			var viewModel = new AuthorFormVM
			{
				Id = id,
				Name = author.Name
			};

			return View("Form", viewModel);
		}

		[HttpPost]
		public IActionResult Edit(AuthorFormVM authorFormVM)
		{
			if (!ModelState.IsValid)
			{
				return View("Form", authorFormVM);
			}
			var author = context.Authors.Find(authorFormVM.Id);
			if (author is null)
			{
				return NotFound();
			}
			author.Name = authorFormVM.Name;
			author.UpdatedOn = DateTime.Now;
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult Details(int id)
		{
			var author = context.Authors.Find(id);
			if (author is null)
			{
				return NotFound();
			}
			var viewModel = new AuthorVM
			{
				Id = author.Id,
				Name = author.Name,
				CreatedOn = author.CreatedOn,
				UpdatedOn = author.UpdatedOn,
			};
			return View(viewModel);
		}

		public IActionResult Delete(int id)
		{
			var author = context.Authors.Find(id);
			if (author is null)
			{
				return NotFound();
			}
			context.Authors.Remove(author);
			context.SaveChanges();
			return Ok();
		}

		public IActionResult CheckName(AuthorFormVM authorFormVM)
		{
			var isExists = context.Authors.Any(author => author.Name == authorFormVM.Name);
			return Json(!isExists);
		}
	}

}
