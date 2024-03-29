using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string? Title { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        
        [Required, RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), StringLength(30)]
        public string? Genre { get; set; }
        
        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [DisplayFormat(ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }

        [Required, StringLength(5), RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public string? Rating {get; set; }
    }
}