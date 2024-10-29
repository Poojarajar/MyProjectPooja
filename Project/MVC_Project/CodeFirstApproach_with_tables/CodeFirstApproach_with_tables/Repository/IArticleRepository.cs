using CodeFirstApproach_with_2_tables.Models;

namespace CodeFirstApproach_with_2_tables.Repository
{
    public interface IArticleRepository
    {
        Article AddArticle(Article article);
        Article UpdateArticle(Article article);
        string DeleteArticle(int id);   
        Article GetArticleById(int id);
        IEnumerable<Article> GetAllArticles();
        IEnumerable<Article> GetArticleByTutorialId(int tutorialId);
    }
}
