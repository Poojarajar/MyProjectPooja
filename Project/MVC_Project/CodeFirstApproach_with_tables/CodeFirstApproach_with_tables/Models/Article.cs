//using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach_with_2_tables.Models
{
    //[Table("tbleArticle")]
    public class Article
    {
        public int? ArticleId { get; set; }

        //[Key]
        [Required(ErrorMessage = "please enter Article Title")]
        public string ArticleTitle { get; set; }
        [Required(ErrorMessage = "please enter Article Content")]
        public string ArticleContent { get; set; }

        public int TutorialId { get; set; }
        public Tutorial? Tutorials { get; set; } = null;
    }
}
