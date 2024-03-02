using Programing;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// находит имена всех перечислений в папке Enums и возвращает их названия
        /// </summary>
        /// <returns>string[]</returns>
        private string[] GetEnumsNames()
        {
            const string directoryPath = @"C:\Users\5733bap\Source\Repos\Programming\Programming\Programming\Models\Enums\";
            var directory = Directory
                .GetFiles(directoryPath, "*", SearchOption.TopDirectoryOnly)
                .Select(fileName => Path.GetFileNameWithoutExtension(fileName)).ToArray();
            return directory;
        }

        /// <summary>
        /// при загрузке формы инициалиируем значениями EnumsListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">запуск MainForm</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.Items.AddRange(GetEnumsNames());
            EnumsListBox.SelectedIndex = 0;
        }

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
                    break;
                case "Weekday":
                    return typeof(Weekday);
                    break;
                case "EducationForm":
                    return typeof(EducationForm);
                    break;
                case "Genre":
                    return typeof(Genre);
                    break;
                case "Manufacture":
                    return typeof(Manufacture);
                    break;
                case "Season":
                    return typeof(Season);
                    break;
            }
            return null;
        }

        /// <summary>
        /// при выборе Enum удаляет и меняет значения ValueListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">выбор нового элемента в EnumsListBox</param>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();

            Type selectedEnum = GetSelectedEnum();
            if (selectedEnum == null)
            {
                ValuesListBox.Items.Add("Элементы не найдены");
                return;
            }

            foreach (var value in Enum.GetValues(selectedEnum))
                ValuesListBox.Items.Add(value);

            ValuesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// при выборе нового элемента в ValuesListBox меняет значение IntValue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">выбор нового элемента в ValuesListBox</param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedValue = ValuesListBox.SelectedItem.ToString();
            Type selectedEnum = GetSelectedEnum();
            if (selectedEnum == null)
            {
                return;
            }

            IntValue.Text = $"{(int)Enum.Parse(selectedEnum, SelectedValue)}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeekdayParsingButton_Click(object sender, EventArgs e)
        {
            object? parsedWeekday;
            string weekday = WeekdayTextBox.Text;
            bool isWeek = Enum.TryParse(typeof(Weekday), weekday, true, out parsedWeekday);
            if (isWeek)
            {
                ParsedWeekdayLabel.Text = $"это день недели({parsedWeekday.ToString()} = {(int)parsedWeekday})";
            }
            else
            {
                ParsedWeekdayLabel.Text = "Нет такого дня недели";
            }
        }
    }
}