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
        /// �������� ��������� Enum
        /// </summary>
        /// <returns>Type, ���� �������� ��� - null</returns>
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
        /// ��� ������ Enum ������� � ������ �������� ValueListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">����� ������ �������� � EnumsListBox</param>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();

            Type selectedEnum = GetSelectedEnum();
            if (selectedEnum == null)
            {
                ValuesListBox.Items.Add("�������� �� �������");
                return;
            }

            foreach (var value in Enum.GetValues(selectedEnum))
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
                ParsedWeekdayLabel.Text = $"��� ���� ������({parsedWeekday.ToString()} = {(int)parsedWeekday})";
            }
            else
            {
                ParsedWeekdayLabel.Text = "��� ������ ��� ������";
            }
        }
    }
}