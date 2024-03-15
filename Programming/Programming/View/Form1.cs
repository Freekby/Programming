namespace Programming
{
    public partial class MainForm : Form
    {
        private string[] _colors = new string[] { "red", "yellow", "green" };
        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle;

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
        }

        //***Lab2***//

        /// <summary>
        /// инициализирует массив _rectangles объектами 
        /// </summary>
        private void InitializeRectangles()
        {
            Random random = new Random();
            for (int i = 0; i < _rectangles.Length; i++)
            {
                double lenght = random.Next(0, 100000) / 1000d;
                double width = random.Next(0, 100000) / 1000d;
                int colorId = random.Next(0, _colors.Length);
                _rectangles[i] = new Rectangle(lenght, width, _colors[colorId]);
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            LenghtTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text.ToLower();
        }

        //***Lab1***//

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
                    MessageBox.Show("сейчас зима");
                    break;
                case Season.Spring:
                    MessageBox.Show("сейчас весна");
                    break;
                case Season.Summer:
                    MessageBox.Show("сейчас лето");
                    break;
                case Season.Autmn:
                    MessageBox.Show("сейчас осень");
                    break;
            }
        }
    }
}