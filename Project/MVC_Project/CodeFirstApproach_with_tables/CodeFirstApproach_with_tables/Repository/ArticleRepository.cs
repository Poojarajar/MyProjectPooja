using CodeFirstApproach_with_2_tables.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach_with_2_tables.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly TutorialDbContext _context;
        public ArticleRepository(TutorialDbContext context)
        {
            _context = context;
        }
        public Article AddArticle(Article article)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.[Articles] ON");

                _context.Add(article);
                _context.SaveChanges();

                transaction.Commit();
                return article;
            }
            //throw new NotImplementedException();
        }

        public string DeleteArticle(int id)
        {
            if (id > 0)
            {

                Article article = _context.Articles.FirstOrDefault(a => a.ArticleId == id);
                if (article != null)
                {
                    _context.Articles.Remove(article);
                    _context.SaveChanges();
                    return "Article removed";
                }
                else
                {
                    return "Id not Found";
                }
            }
            else
            {
                return "Id is not valid";
            }
                //throw new NotImplementedException();
            
        }

        public IEnumerable<Article> GetAllArticles()
        {
            var articles = _context.Articles;
            if (articles != null)
                return articles;
            else
                return null;
            //throw new NotImplementedException();
        }

        public Article GetArticleById(int id)
        {
            if(id !=0 || id != null)
            {
                var article = _context.Articles.FirstOrDefault(a => a.ArticleId == id);
                if (article != null)
                    return article;
            }
            return null;
            //throw new NotImplementedException();
        }

        public IEnumerable<Article> GetArticleByTutorialId(int tutorialId)
        {
            //throw new NotImplementedException();
            return _context.Articles.Where(a => a.TutorialId == tutorialId).ToList();
        }

        public Article UpdateArticle(Article newarticle)
        {
            if(newarticle != null)
            {
                var artcile = _context.Articles.FirstOrDefault(a => a.ArticleId == newarticle.ArticleId);
                if(artcile != null)
                {
                    artcile.ArticleTitle = newarticle.ArticleTitle;
                    artcile.ArticleContent = newarticle.ArticleContent;
                    artcile.TutorialId = newarticle.TutorialId;
                    _context.Entry(artcile).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                return newarticle;
            }
            return null;
            //throw new NotImplementedException();
        }
    }
}
