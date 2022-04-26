using System.ComponentModel.DataAnnotations;

namespace csharpik.Models.BookProject
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Surname { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }
}
