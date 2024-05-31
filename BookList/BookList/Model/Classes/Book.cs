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
        /// ���������� ��������� ������ Book
        /// </summary>
        /// <param name="title">�������� �����</param>
        /// <param name="year">��� �������</param>
        /// <param name="author">�����</param>
        /// <param name="numOfPages">���������� �������</param>
        /// <param name="genre">����</param>
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
        /// ��������� ������, ������� ��������� �����;
        /// </summary>
        /// <returns>string</returns>
        override public string ToString()
        {
            return $"{Title}/{Author}/{Genre}";
        }

        /// <summary>
        /// ID �����
        /// </summary>
        public int ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        /// <summary>
        /// �������� �����
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
        /// ��� ������� �����
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
        /// ����� �����
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
        /// ���������� ������� � �����
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
        /// ���� �����
        /// </summary>
        public Genres Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
    }
}