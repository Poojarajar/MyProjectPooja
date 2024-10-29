using Microsoft.AspNetCore.Mvc;
using CodeFirstApproach_with_2_tables.Models;
using CodeFirstApproach_with_2_tables.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodeFirstApproach_with_2_tables.Controllers
{
    public class ArticleController : Controller
    {
        public readonly IArticleRepository _articleRepository;
        private readonly TutorialDbContext _context;
        public ArticleController(IArticleRepository articleRepository, TutorialDbContext context)
        {
        _articleRepository = articleRepository;
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_articleRepository.GetAllArticles());
        }

        public IActionResult Details(int id)
        {
            return View(_articleRepository.GetArticleById(id));
        }

        public IActionResult Create() {
            ViewData["TutorialId"] = new SelectList(_context.Tutorials, "TutorialId", "TutorialId");
                return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ArticleId,ArticleTitle,ArticleConent,TutorialId")] Article article)
        {
            if (ModelState.IsValid)
            {
                _articleRepository.AddArticle(article);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View(_articleRepository.GetArticleById(id));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            return View(_articleRepository.DeleteArticle(id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _articleRepository.DeleteArticle(id);
            return RedirectToAction("Index");
        }
    }
}
