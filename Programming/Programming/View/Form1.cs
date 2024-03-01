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
        /// ������� ����� ���� ������������ � ����� Enums � ���������� �� ��������
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
        /// ��� �������� ����� ������������� ���������� EnumsListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">������ MainForm</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.Items.AddRange(GetEnumsNames());
            EnumsListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// �������� ��� �������� ���������� Enum 
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
            return new string[] { "��������� �� �������" };
        }

        /// <summary>
        /// ��� ������ Enum ������� � ������ �������� ValueListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">����� ������ �������� � EnumsListBox</param>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            foreach (var value in GetSelectedEnumValues())
                ValuesListBox.Items.Add(value);

            ValuesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// ��� ������ ������ �������� � ValuesListBox ������ �������� IntValue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">����� ������ �������� � ValuesListBox</param>
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
                ParsedWeekdayLabel.Text = $"��� ���� ������({parsedWeekday.ToString()} = {(int)parsedWeekday})";
            }
            else
            {
                ParsedWeekdayLabel.Text = "��� ������ ��� ������";
            }
        }
    }
}