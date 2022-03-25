using System.ComponentModel.DataAnnotations;

namespace csharpik.Models.BookProject
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        public List<Book> Books { get; set; } 
    }
}
