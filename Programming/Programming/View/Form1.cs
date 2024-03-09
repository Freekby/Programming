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

            SeasonsComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonsComboBox.SelectedIndex = 0;

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
        /// ��� ������ Enum ������� � ������ �������� ValueListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">����� ������ �������� � EnumsListBox</param>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type selectedEnum = GetSelectedEnum();
            if (selectedEnum == null)
            {
                ValuesListBox.Items.Add("�������� �� �������");
                return;
            }

            ValuesListBox.DataSource = Enum.GetValues(selectedEnum);
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
        /// ��������� �� ������ ������ � ��� ������ � �������� ����� ��� � Season
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
                ParsedWeekdayLabel.Text = $"��� ���� ������({parsedWeekday} = {(int)parsedWeekday})";
            }
            else
            {
                ParsedWeekdayLabel.Text = "��� ������ ��� ������";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            Season currentSeason = (Season)SeasonsComboBox.SelectedItem;
            switch (currentSeason)
            {
                case Season.Winter:
                    MessageBox.Show("������ ����");
                    break;
                case Season.Spring:
                    MessageBox.Show("������ �����");
                    break;
                case Season.Summer:
                    MessageBox.Show("������ ����");
                    break;
                case Season.Autmn:
                    MessageBox.Show("������ �����");
                    break;
            }
        }
    }
}