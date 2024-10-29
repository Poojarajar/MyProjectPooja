using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproach_with_2_tables.Models
{
    public class Tutorial
    {
        public int TutorialId { get; set; }
        [RegularExpression(@"^[a-zA-Z-_]*$", ErrorMessage = "please enter text")]
        [Required]
        [Display(Name = "Tutorial Name")]
        public string? TutorialName { get; set; }
        [Required]
        [Display(Name = "Tutorial Description")]
        public string? TutorialDescription { get; set; }

        public virtual ICollection<Article> Articles { get; set; } = new List<Article>();   
    }
}
