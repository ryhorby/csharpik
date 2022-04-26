namespace csharpik.Models.BookProject
{
    public class DescriptionModel
    {
        public Book Book { get; set; }

        public Author BookAuthor { get; set; }

        public BookUrlKeeper Keeper { get; set; } 
    }
}
