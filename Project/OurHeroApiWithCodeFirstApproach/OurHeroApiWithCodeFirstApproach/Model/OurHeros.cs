using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OurHeroApiWithCodeFirstApproach.Model
{

    [Table("tblOurHeros")]
    public class OurHeros
    {
        [Key]
        public int? Id { get; set; }

        //[Key]
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public bool isActive { get; set; }
       

    }

}
