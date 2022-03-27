namespace csharpik.Models.BookProject
{
    public class DescriptionModel
    {
        public Book Book { get; set; }

        public Author BookAuthor { get; set; }

        public BookNameKeeper Keeper { get; set; } 
    }
}
