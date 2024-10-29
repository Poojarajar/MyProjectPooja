using CodeFirstApproach_with_2_tables.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach_with_2_tables.Repository
{
    public class TutorialRepository : ITutorialRepository
    {
        private readonly TutorialDbContext _context;
        public TutorialRepository(TutorialDbContext context)
        {
            _context = context;
        }
        public Tutorial AddTutorial(Tutorial Tutorial)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.[Tutorials] ON");

                _context.Add(Tutorial);
                _context.SaveChanges();

                transaction.Commit();
                return Tutorial;
            }
            //throw new NotImplementedException();
        }

        public string DeleteTutorial(int id)
        {
            if (id > 0)
            {

                Tutorial Tutorial = _context.Tutorials.FirstOrDefault(a => a.TutorialId == id);
                if (Tutorial != null)
                {
                    _context.Tutorials.Remove(Tutorial);
                    _context.SaveChanges();
                    return "Tutorial removed";
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

        public IEnumerable<Tutorial> GetAllTutorial()
        {
            var Tutorials = _context.Tutorials;
            if (Tutorials != null)
                return Tutorials;
            else
                return null;
            //throw new NotImplementedException();
        }

        public Tutorial GetTutorialById(int id)
        {
            if (id != 0 || id != null)
            {
                var Tutorial = _context.Tutorials.FirstOrDefault(a => a.TutorialId == id);
                if (Tutorial != null)
                    return Tutorial;
            }
            return null;
            //throw new NotImplementedException();
        }

        public IEnumerable<Tutorial> GetTutorialByArticleId(int articleId)
        {
            //throw new NotImplementedException();
            return _context.Tutorials.Where(a => a.TutorialId == articleId).ToList();
        }

        public Tutorial UpdateTutorial(Tutorial newtutorial)
        {
            if (newtutorial != null)
            {
                var tutorial = _context.Tutorials.FirstOrDefault(a => a.TutorialId == newtutorial.TutorialId);
                if (tutorial != null)
                {
                    //tutorial.TutorialTitle = newtutorial.TutorialTitle;
                    tutorial.TutorialName = newtutorial.TutorialName;
                    tutorial.TutorialDescription = newtutorial.TutorialDescription;
                    _context.Entry(tutorial).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                return newtutorial;
            }
            return null;
            //throw new NotImplementedException();
        }
    }
}
