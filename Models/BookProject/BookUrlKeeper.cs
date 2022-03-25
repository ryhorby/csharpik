using System.ComponentModel.DataAnnotations;

namespace csharpik.Models.BookProject
{
    public class BookUrlKeeper
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PdfFileName { get; set; }

        [Required]
        public string PictureFileName { get; set; }

        public int? BookId { get; set; }
        public Book Book { get; set; }
    }
}