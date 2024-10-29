using Microsoft.EntityFrameworkCore;
using OurHeroApiWithCodeFirstApproach.Entity;
using OurHeroApiWithCodeFirstApproach.Model;
namespace OurHeroApiWithCodeFirstApproach.Services
{
    public class OurHeroService : IOurHeroService
    {
        private readonly OurHeroDbContext _db;
        public OurHeroService(OurHeroDbContext db)
        {
            _db = db;
        }

        public async Task<List<OurHeros>> GetAllHeros(bool? isActive)
        {
            if (isActive == null) { return await _db.OurHero.ToListAsync(); }

            return await _db.OurHero.Where(obj => obj.isActive == isActive).ToListAsync();
        }

        public async Task<OurHeros?> GetHerosByID(int id)
        {
            return await _db.OurHero.FirstOrDefaultAsync(hero => hero.Id == id);
        }

        public async Task<OurHeros?> AddOurHero(AddUpdateOurHero obj)
        {
            var addHero = new OurHeros()
            {
                FirstName = obj.FirstName,
                LastName = obj.LastName,
                isActive = obj.isActive,
            };

            _db.OurHero.Add(addHero);
            var result = await _db.SaveChangesAsync();
            return result >= 0 ? addHero : null;
        }

        public async Task<OurHeros?> UpdateOurHero(int id, AddUpdateOurHero obj)
        {
            var hero = await _db.OurHero.FirstOrDefaultAsync(index => index.Id == id);
            if (hero != null)
            {
                hero.FirstName = obj.FirstName;
                hero.LastName = obj.LastName;
                hero.isActive = obj.isActive;

                var result = await _db.SaveChangesAsync();
                return result >= 0 ? hero : null;
            }
            return null;
        }

        public async Task<bool> DeleteHerosByID(int id)
        {
            var hero = await _db.OurHero.FirstOrDefaultAsync(index => index.Id == id);
            if (hero != null)
            {
                _db.OurHero.Remove(hero);
                var result = await _db.SaveChangesAsync();
                return result >= 0;
            }
            return false;
        }


    }
}
