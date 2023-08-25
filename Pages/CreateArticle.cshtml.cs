using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_blog.Models;

namespace Razor_blog.Pages
{
    public class CreateArticleModel : PageModel
    {

        public CreateArticle Command { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        private readonly BlogContext _context;

        public CreateArticleModel(BlogContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(CreateArticle command)
        {

            if (ModelState.IsValid)
            {
                var articles = new Article(command.Title,
                command.Picture, command.PictureTitle,
                command.PictureAlt, command.ShortDescription, command.Body);

                _context.Articles.Add(articles);
                _context.SaveChanges();
                return RedirectToPage("./Index");
            }
            else
            {
                ErrorMessage = "fill up some inputs please!";
                return Page();
            }

        }
    }
}
