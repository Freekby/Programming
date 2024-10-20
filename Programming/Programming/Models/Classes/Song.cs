﻿namespace Programming
{
    public class Song
    {
        private int _duration;

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
            get { return _duration; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }
    }
}