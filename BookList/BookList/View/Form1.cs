using System.Text.Json;

namespace BookList
{
    public partial class MainForm : Form
    {
        private List<Book> booksList = new List<Book>();
        private Book currentBook;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// �������������� ���������  ���������� ��� ������� �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

            if (booksList.Count == 0)
            {
                booksList.Add(BookGenerator.Randomize());
            }
            currentBook = booksList[0];

            GenreComboBox.DataSource = Enum.GetValues(typeof(Genres));
            GenreComboBox.SelectedIndex = 0;

            RewriteData();
            BooksListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// ��������� ������ 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void BooksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedIndex < 0)
            {
                AuthorTextBox.Clear();
                TitleTextBox.Clear();
                YearTextBox.Clear();
                NumOfPagesTextBox.Clear();
                GenreComboBox.SelectedIndex = 0;
            }
            else
            {
                currentBook = booksList[BooksListBox.SelectedIndex];

                AuthorTextBox.Text = currentBook.Author;
                TitleTextBox.Text = currentBook.Title;
                YearTextBox.Text = currentBook.Year.ToString();
                NumOfPagesTextBox.Text = currentBook.NumOfPages.ToString();
            }
        }



        /// <summary>
        /// ��������� ���������� � �����
        /// </summary>
        private void SaveBookInfo()
        {
            try
            {
                string newTitle = TitleTextBox.Text;
                currentBook.Title = newTitle;
            }
            catch (Exception)
            {
                MessageBox.Show("����������� ������� ��������!", "������"); ;
            }

            try
            {
                int newNumOfPages = int.Parse(NumOfPagesTextBox.Text);
                currentBook.NumOfPages = newNumOfPages;
            }
            catch (Exception)
            {
                MessageBox.Show("����������� ������� ���������� �������!", "������");
            }

            try
            {
                string newAuthor = AuthorTextBox.Text;
                currentBook.Author = newAuthor;
            }
            catch (Exception)
            {
                MessageBox.Show("����������� ������� ��� ������!", "������");
            }

            try
            {
                int newYear = int.Parse(YearTextBox.Text);
                currentBook.Year = newYear;
            }
            catch (Exception)
            {
                MessageBox.Show("����������� ������� ���� �������!", "������");
            }

            Genres newGenre = (Genres)GenreComboBox.SelectedValue;
            currentBook.Genre = newGenre;

            BooksListBox.Items[BooksListBox.SelectedIndex] = currentBook.ToString();
            BooksListBox.Sorted = true;

            RewriteData();

        }

        /// <summary>
        /// ������������ � ��������� ������ 
        /// </summary>
        private void RewriteData()
        {
            booksList.Sort((x, y) => x.ToString().CompareTo(y.ToString()));
            BooksListBox.Items.Clear();
            foreach (Book book in booksList)
            {
                BooksListBox.Items.Add(book.ToString());
            }
        }

        /// <summary>
        /// ��������� ���������� � �����
        /// </summary>
        /// <param name="sender">SaveBookInfoButton</param>
        /// <param name="e"></param>
        private void SaveBookInfoButton_Click(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedIndex == -1)
            {
                return;
            }
            SaveBookInfo();

            AuthorTextBox.Clear();
            TitleTextBox.Clear();
            YearTextBox.Clear();
            NumOfPagesTextBox.Clear();
            GenreComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// ��������� ����� ������� 
        /// </summary>
        /// <param name="sender">AddBookButton</param>
        /// <param name="e"></param>
        private void AddBookButton_Click(object sender, EventArgs e)
        {
            booksList.Add(BookGenerator.Randomize());
            RewriteData();
        }

        /// <summary>
        /// ������� �������
        /// </summary>
        /// <param name="sender">RemoveBookButton</param>
        /// <param name="e"></param>
        private void RemoveBookButton_Click(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedIndex == -1) { return; }
            booksList.RemoveAt(BooksListBox.SelectedIndex);
            BooksListBox.Items.RemoveAt(BooksListBox.SelectedIndex);

            RewriteData();
        }

        /// <summary>
        /// ��������� ������.
        /// </summary>
        public void SaveData()
        {
            string path = Environment.CurrentDirectory + @"\data.txt";
            string data = JsonSerializer.Serialize(booksList);
            File.WriteAllText(path, data);
        }

        ///<summary>
        /// ��������� ������. 
        /// </summary>
        public void LoadData()
        {
            string path = Environment.CurrentDirectory + @"\data.txt";
            if (!File.Exists(path)) return;
            string data = File.ReadAllText(path);
            booksList = JsonSerializer.Deserialize<List<Book>>(data);
            RewriteData();
        }
    }
}