namespace BookList
{
    public static class BookGenerator
    {
        private static int _count = 0;

        /// <summary>
        /// Генерирует экземпляр класса Book 
        /// </summary>
        /// <returns>Book</returns>
        public static Book Randomize()
        {
            Random random = new Random();
            string author = $"author{_count}";
            string title = $"title{_count}";
            int year = random.Next(0, DateTime.Now.Year);
            int numOfPages = random.Next(1, 1000);
            Genres genre = (Genres)random.Next(0,15);

            Book book = new Book(title, year, author, numOfPages, genre);
            _count++;
            return book;
        }
    }
}