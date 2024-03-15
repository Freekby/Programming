namespace Programming
{
    public class Song
    {
        private int duration;
        public string Title { get; set; }
        public string Artist { get; set; }

        public Song(string title, string artist, int duration)
        {
            this.Title = title;
            this.Artist = artist;
            this.Duration = duration;
        }

        public Song()
        {
        }

        public int Duration
        {
            get { return duration; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("продолжительность должна быть больше 0");
                }
                duration = value;
            }
        }
    }
}