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
        /// ��� �������� ����� ������������� ���������� SeasonsComboBox � _rectangles
        /// ���������� ��������� ������� EnumsListBox, SeasonsComboBox � RectanglesListBox �� 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">�������� MainForm</param>
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
        /// �������������� ������ _rectangles ��������� 
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

            IntValue.Text = $"{(int)Enum.Parse(selectedEnum, SelectedValue)}";
        }

        /// <summary>
        /// ��������� �� ������ ������ � ��� ������ � �������� ����� ��� � Season
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">������� WeekdayParsingButton</param>
        private void WeekdayParsingButton_Click(object sender, EventArgs e)
        {
            string weekday = WeekdayTextBox.Text;
            object? parsedWeekday;
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

        /// <summary>
        /// ��������� �������� �� SeasonsComboBox � � ����������� �� �������� �������� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">������� GoButton</param>
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