using System.ComponentModel.DataAnnotations;

namespace OurHeroApiWithCodeFirstApproach.Model
{
    public class AddUpdateOurHero
    {
        public int? Id { get; set; }

        //[Key]
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public bool isActive { get; set; }
    }
}
