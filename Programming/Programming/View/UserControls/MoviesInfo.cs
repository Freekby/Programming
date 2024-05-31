namespace Programming.View
{
    public partial class MoviesInfo : UserControl
    {
        public MoviesInfo()
        {
            InitializeComponent();
        }

        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie;

        /// <summary>
        /// инициализирует массив _movies объектами 
        /// </summary>
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

        /// <summary>
        /// при измененинии выбранного прямоугольника отображает его характеристики
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[MovieListBox.SelectedIndex];

            MovieDurationTextBox.Text = _currentMovie.DurationInMinutes.ToString();
            MovieGenreTextBox.Text = _currentMovie.Genre.ToString();
            MovieRatingTextBox.Text = _currentMovie.Rating.ToString();
            MovieReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            MovieTitleTextBox.Text = _currentMovie.Title.ToString();
        }

        /// <summary>
        /// при изменении текста в  MovieDurationTextBox меняет значение Duration в выбранном фильме
        /// </summary>
        /// <param name="sender">MovieDurationTextBox</param>
        /// <param name="e"></param>
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

        /// <summary>
        /// при изменении текста в MovieReleaseYearTextBox меняет значение ReleaseYear в выбранном фильме
        /// </summary>
        /// <param name="sender">MovieReleaseYearTextBox</param>
        /// <param name="e"></param>
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

        /// <summary>
        /// при изменении текста в MovieRatingTextBox меняет значение Rating в выбранном фильме
        /// </summary>
        /// <param name="sender">MovieRatingTextBox</param>
        /// <param name="e"></param>
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

        /// <summary>
        /// при изменении текста в MovieTitleTextBox меняет значение Title в выбранном фильме
        /// </summary>
        /// <param name="sender">MovieTitleTextBox</param>
        /// <param name="e"></param>
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

        /// <summary>
        /// при изменении текста в MovieGenreTextBox меняет значение Genre в выбранном фильме
        /// </summary>
        /// <param name="sender">MovieGenreTextBox</param>
        /// <param name="e"></param>
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

        /// <summary>
        /// находит фильм с самым больши рейтингом в массиве
        /// </summary>
        /// <param name="movies">массив фильмов</param>
        /// <returns>int</returns>
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

        /// <summary>
        /// устанавливает значение выбранного фильма на тот, у которого самый большой рейтиг
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieFindButton_Click(object sender, EventArgs e)
        {
            MovieListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }

        /// <summary>
        /// инициаизирует некоторые значения при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoviesInfo_Load(object sender, EventArgs e)
        {
            InitialiseMovies();
            MovieListBox.SelectedIndex = 0;
        }
    }
}
