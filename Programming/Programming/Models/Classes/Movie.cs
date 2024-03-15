namespace Programming
{
    public class Movie
    {
        private string Title { get; set; }
        private int durationInMinutes;
        private int releaseYear;
        private string Genre { get; set; }
        private double rating;

        public Movie()
        {
        }

        public Movie(string title, int durationInMinutes, int releaseYear, string genre, double rating)
        {
            Title = title;
            DurationInMinutes = durationInMinutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }

        public int DurationInMinutes
        {
            get { return durationInMinutes; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Продолжительность фильма не может быть отрицательной.");
                }
                durationInMinutes = value;
            }
        }

        public int ReleaseYear
        {
            get { return releaseYear; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Год выпуска фильма должен быть в диапазоне от 1900 до текущего года.");
                }
                releaseYear = value;
            }
        }

        public double Rating
        {
            get { return rating; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Рейтинг фильма должен быть в диапазоне от 0 до 10.");
                }
                rating = value;
            }
        }
    }
}
