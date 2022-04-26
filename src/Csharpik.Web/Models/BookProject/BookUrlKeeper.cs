using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharpik.Models.BookProject
{
    public class BookUrlKeeper
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string PdfFileName { get; set; }

        [Required]
        [MaxLength(50)]
        public string PictureFileName { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}