namespace Programming.View
{
    public partial class WeekdayParsing : UserControl
    {
        public WeekdayParsing()
        {
            InitializeComponent();
        }

        private void WeekdayGroupBox_SizeChanged(object sender, EventArgs e)
        {
            WeekdayTextBox.Width = this.Width - 87;
            WeekdayParsingButton.Left = this.Width - 78;
        }

        /// <summary>
        /// показыает на экране строку с днём недели и индексом этого дня в Season
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
                    ParsedWeekdayLabel.Text = "Нет такого дня недели";
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
                ParsedWeekdayLabel.Text = "Нет такого дня недели";
            }
        }
    }
}
