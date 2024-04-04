namespace Programming
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// при загрузке формы инициалиирует значени€ми SeasonsComboBox и _rectangles
        /// выставл€ет выбранные индексы EnumsListBox, SeasonsComboBox и RectanglesListBox на 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">загрузка MainForm</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.SelectedIndex = 0;

            SeasonsComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonsComboBox.SelectedIndex = 0;

            InitializeRectangles();
            RectanglesListBox.SelectedIndex = 0;

            InitialiseMovies();
            MovieListBox.SelectedIndex = 0;
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 2)
            {
                this.Size = new Size(820, 430);
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        #region Classes

        #region Rectangles

        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle;

        /// <summary>
        /// инициализирует массив _rectangles объектами 
        /// </summary>
        private void InitializeRectangles()
        {
            Random random = new Random();
            for (int i = 0; i < _rectangles.Length; i++)
            {
                double lenght = random.Next(0, 10000) / 100d;
                double width = random.Next(0, 10000) / 100d;
                double CenterX = random.Next(0, 100000) / 100d;
                double CenterY = random.Next(0, 100000) / 100d;
                int RandomColorId = random.Next(0, Enum.GetValues(typeof(Color)).Length);
                string color = Enum.GetValues(typeof(Color)).GetValue(RandomColorId).ToString();

                _rectangles[i] = new Rectangle(lenght, width, color, CenterX, CenterY);
            }
        }

        /// <summary>
        /// при измененинии выбранного пр€моугольника отображает его характеристики
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            RectagleLenghtTextBox.Text = _currentRectangle.Height.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleColorTextBox.Text = _currentRectangle.Color;
            RectangleCenterXTextBox.Text = _currentRectangle.Center.X.ToString();
            RectangleCenterYTextBox.Text = _currentRectangle.Center.Y.ToString();
            RectangleIdTextBox.Text = _currentRectangle.Id.ToString();
        }

        /// <summary>
        /// при изменении текста в RectangleLenghtTextBox мен€ет значение Lenght в выбранном пр€моугольнике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleLenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double lenght = double.Parse(RectagleLenghtTextBox.Text);
                _currentRectangle.Height = lenght;
                RectagleLenghtTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                RectagleLenghtTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// при изменении текста в RectangleWidthTextBox мен€ет значение Width в выбранном пр€моугольнике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double Width = double.Parse(RectangleWidthTextBox.Text);
                _currentRectangle.Width = Width;
                RectangleWidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                RectangleWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// при изменении текста в RectangleColorTextBox мен€ет значение Color в выбранном пр€моугольнике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = RectangleColorTextBox.Text;
        }

        /// <summary>
        /// Ќаходит пр€моугольник с максимальным параметром Width 
        /// </summary>
        /// <param name="rectangles">массив пр€моугольников</param>
        /// <returns>int</returns>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int rectangleWithMaxWidthIndex = 0;
            for (int rect = 0; rect < rectangles.Length; rect++)
            {
                if (rectangles[rect].Width > rectangles[rectangleWithMaxWidthIndex].Width)
                {
                    rectangleWithMaxWidthIndex = rect;
                }
            }
            return rectangleWithMaxWidthIndex;
        }

        /// <summary>
        /// ¬ыбирает в качестве активного элемента в RectanglesListBox элемент с максимальным Width
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
        #endregion

        #region Movies
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie;

        private void InitialiseMovies()
        {
            Random random = new Random();
            for (int i = 0; i < _movies.Length; i++)
            {
                int duration = random.Next(1, 300 + 1);
                int releaseYear = random.Next(1900, DateTime.Now.Year);
                int rating = random.Next(0, 11);
                string title = $"Any title {i}";
                int RandomGenreId = random.Next(0, Enum.GetValues(typeof(Genre)).Length);
                string genre = Enum.GetValues(typeof(Genre)).GetValue(RandomGenreId).ToString();

                _movies[i] = new Movie(title, duration, releaseYear, genre, rating);
            }
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[MovieListBox.SelectedIndex];

            MovieDurationTextBox.Text = _currentMovie.DurationInMinutes.ToString();
            MovieGenreTextBox.Text = _currentMovie.Genre.ToString();
            MovieRatingTextBox.Text = _currentMovie.Rating.ToString();
            MovieReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            MovieTitleTextBox.Text = _currentMovie.Title.ToString();
        }

        private void MovieDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int ParsedDuration = int.Parse(MovieDurationTextBox.Text);
                _currentMovie.DurationInMinutes = ParsedDuration;
                MovieDurationTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                MovieDurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void MovieReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int releaseYear = int.Parse(MovieReleaseYearTextBox.Text);
                _currentMovie.ReleaseYear = releaseYear;
                MovieReleaseYearTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                MovieReleaseYearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void MovieRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int rating = int.Parse(MovieRatingTextBox.Text);
                _currentMovie.Rating = rating;
                MovieRatingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                MovieRatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void MovieTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Title = MovieTitleTextBox.Text;
                MovieTitleTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                MovieTitleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void MovieGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Genre = MovieGenreTextBox.Text;
                MovieGenreTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                MovieGenreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private int FindMovieWithMaxRating(Movie[] movies)
        {
            int movieWithMaxRatingIndex = 0;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[movieWithMaxRatingIndex].Rating < movies[i].Rating)
                {
                    movieWithMaxRatingIndex = i;
                }
            }
            return movieWithMaxRatingIndex;
        }

        private void MovieFindButton_Click(object sender, EventArgs e)
        {
            MovieListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }
        #endregion

        #endregion

        #region Enumerations

        /// <summary>
        /// получает выбранный Enum
        /// </summary>
        /// <returns>Type, если элемента нет - null</returns>
        private Type GetSelectedEnum()
        {
            string CurrentEnumName = EnumsListBox.SelectedItem.ToString();

            switch (CurrentEnumName)
            {
                case "Color":
                    return typeof(Color);
                case "Weekday":
                    return typeof(Weekday);
                case "EducationForm":
                    return typeof(EducationForm);
                case "Genre":
                    return typeof(Genre);
                case "Manufacture":
                    return typeof(Manufacture);
                case "Season":
                    return typeof(Season);
            }
            return null;
        }

        /// <summary>
        /// при выборе Enum удал€ет и мен€ет значени€ ValueListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">выбор нового элемента в EnumsListBox</param>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type selectedEnum = GetSelectedEnum();
            if (selectedEnum == null)
            {
                ValuesListBox.Items.Add("Ёлементы не найдены");
                return;
            }

            ValuesListBox.DataSource = Enum.GetValues(selectedEnum);
            ValuesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// при выборе нового элемента в ValuesListBox мен€ет значение IntValue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">выбор нового элемента в ValuesListBox</param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedValue = ValuesListBox.SelectedItem.ToString();
            Type selectedEnum = GetSelectedEnum();

            IntValue.Text = $"{(int)Enum.Parse(selectedEnum, SelectedValue)}";
        }

        /// <summary>
        /// показыает на экране строку с днЄм недели и индексом этого дн€ в Season
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">нажатие WeekdayParsingButton</param>
        private void WeekdayParsingButton_Click(object sender, EventArgs e)
        {
            string weekday = WeekdayTextBox.Text;
            foreach (char symbol in weekday)
            {
                if (char.IsDigit(symbol))
                {
                    ParsedWeekdayLabel.Text = "Ќет такого дн€ недели";
                    return;
                }
            }

            object? parsedWeekday;
            bool isWeek = Enum.TryParse(typeof(Weekday), weekday, true, out parsedWeekday);

            if (isWeek)
            {
                ParsedWeekdayLabel.Text = $"это день недели({parsedWeekday} = {(int)parsedWeekday})";
            }
            else
            {
                ParsedWeekdayLabel.Text = "Ќет такого дн€ недели";
            }
        }

        /// <summary>
        /// считывает значение из SeasonsComboBox и в зависимости от значени€ вызывает событие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">нажатие GoButton</param>
        private void GoButton_Click(object sender, EventArgs e)
        {
            Season currentSeason = (Season)SeasonsComboBox.SelectedItem;
            switch (currentSeason)
            {
                case Season.Winter:
                    EnumsPage.BackColor = System.Drawing.Color.White;
                    break;
                case Season.Spring:
                    MessageBox.Show("сейчас весна");
                    break;
                case Season.Summer:
                    EnumsPage.BackColor = System.Drawing.Color.Orange;
                    break;
                case Season.Autmn:
                    MessageBox.Show("сейчас осень");
                    break;
            }
        }
        #endregion

    }
}