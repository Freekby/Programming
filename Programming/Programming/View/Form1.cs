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
        /// получает все значения выбранного Enum 
        /// </summary>
        /// <returns>Array</returns>
        private Array GetSelectedEnumValues()
        {
            string CurrentEnumName = EnumsListBox.SelectedItem.ToString();

            switch (CurrentEnumName)
            {
                case "Color":
                    return Enum.GetValues(typeof(Color));
                    break;
                case "Weekday":
                    return Enum.GetValues(typeof(Weekday));
                    break;
                case "EducationForm":
                    return Enum.GetValues(typeof(EducationForm));
                    break;
                case "Genre":
                    return Enum.GetValues(typeof(Genre));
                    break;
                case "Manufacture":
                    return Enum.GetValues(typeof(Manufacture));
                    break;
                case "Season":
                    return Enum.GetValues(typeof(Season));
                    break;
            }
            return new string[] { "Элементов не найдено" };
        }

        /// <summary>
        /// при выборе Enum удаляет и меняет значения ValueListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">выбор нового элемента в EnumsListBox</param>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            foreach (var value in GetSelectedEnumValues())
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
            bool isWeek = Enum.TryParse(typeof(Weekday), weekday,true, out parsedWeekday);
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