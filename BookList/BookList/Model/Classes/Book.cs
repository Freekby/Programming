namespace BookList
{
    public class Book
    {
        private string _title;
        private int _year;
        private string _author;
        private int _numOfPages;
        private Genres _genre;
        static int _bookNumber = 0;
        private int _id;


        /// <summary>
        /// Генерирует экземпляр класса Book
        /// </summary>
        /// <param name="title">Название книги</param>
        /// <param name="year">Год издания</param>
        /// <param name="author">Автор</param>
        /// <param name="numOfPages">Количество страниц</param>
        /// <param name="genre">Жанр</param>
        public Book(string title, int year, string author, int numOfPages, Genres genre)
        {
            Title = title;
            Year = year;
            Author = author;
            NumOfPages = numOfPages;
            Genre = genre;
            ID = _bookNumber;
            _bookNumber++;
        }

        /// <summary>
        /// вовращает строку, которая описывает класс;
        /// </summary>
        /// <returns>string</returns>
        override public string ToString()
        {
            return $"{Title}/{Author}/{Genre}";
        }

        /// <summary>
        /// ID книги
        /// </summary>
        public int ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        /// <summary>
        /// Название книги
        /// </summary>
        public string Title
        {
            get { return _title; }
            set
            {
                if (value.Length > 100)
                {
                    throw new ArgumentException("Title lenght should be <100");
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Title Lenght should be >0");
                }
                _title = value;
            }
        }

        /// <summary>
        /// Год издания книги
        /// </summary>
        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 0 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException($"year should be <{DateTime.Now.Year}");
                }
                _year = value;
            }
        }

        /// <summary>
        /// Автор книги
        /// </summary>
        public string Author
        {
            get { return _author; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Author name can't be empty");
                }
                _author = value;
            }
        }

        /// <summary>
        /// Количество страниц в книге
        /// </summary>
        public int NumOfPages
        {
            get { return _numOfPages; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of pages should be >0");
                }
                _numOfPages = value;
            }
        }

        /// <summary>
        /// Жанр книги
        /// </summary>
        public Genres Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
    }
}