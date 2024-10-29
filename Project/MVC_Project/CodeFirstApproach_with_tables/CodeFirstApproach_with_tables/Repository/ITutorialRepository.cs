using CodeFirstApproach_with_2_tables.Models;

namespace CodeFirstApproach_with_2_tables.Repository
{
    public interface ITutorialRepository
    {
        Tutorial AddTutorial(Tutorial tutorial);
        Tutorial UpdateTutorial(Tutorial Tutorial);
        string DeleteTutorial(int id);
        Tutorial GetTutorialById(int id);
        IEnumerable<Tutorial> GetAllTutorial();
        IEnumerable<Tutorial> GetTutorialByArticleId(int ArticeId);
    }
}
