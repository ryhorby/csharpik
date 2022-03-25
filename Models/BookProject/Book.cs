using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharpik.Models.BookProject
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public bool IsFree { get; set; }

        public int? AuthorId { get; set; }
        public Author Author { get; set; }

        public BookUrlKeeper UrlKeeper { get; set; }
    }
}