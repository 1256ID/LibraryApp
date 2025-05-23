namespace LibraryApp.Web.Views.Book
{
    public class IndexVM
    {
        public BookVM[] BookVMs { get; set; } = null!;
        public class BookVM
        {
            public required int Id { get; set; } 
            public required string Title { get; set; }
            public required string Author { get; set; }
            public required string Description { get; set; }

        }
    }
}
