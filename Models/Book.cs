namespace BookApi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }

        //pseudo database
        private static List<Book> Library = new List<Book>()
        {
            new Book() { Id = 1, Title = "The Odyssey", Category = "Fiction" },
            new Book() { Id = 2, Title = "Perdido Street Station", Category = "Fiction" }
        };
        private static int NextId = 3;

        //pseudo service
        public static Book AddBook(string title, string category)
        {
            var b = new Book
            {
                Id = NextId++,
                Title = title,
                Category = category
            };
            Library.Add(b);
            return b;
        }

        public static List<Book> GetAll()
        {
            return Library;
        }

        public static Book FindById(int id)
        {
            return Library.First(book => book.Id == id);
        }

        public static List<Book> FindByCategory(string category)
        {
            return Library.FindAll(b => b.Category == category);
        }

        public static List<Book> FindByKeyword(string keyword)
        {
            return Library.FindAll(b => b.Title.ToLower().Contains(keyword.ToLower()));
        }

        public static void UpdateBook(int id, string title, string category)
        {
            var book = Library.SingleOrDefault(b => b.Id == id);
            book.Title = title;
            book.Category = category;
        }

        public static void DeleteBook(int id)
        {
            var book = Library.SingleOrDefault(b => b.Id == id);
            Library.Remove(book);
        }
    }
}
