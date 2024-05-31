namespace Programming.View
{
    public partial class Enumerations : UserControl
    {
        public Enumerations()
        {
            InitializeComponent();
        }

        /// <summary>
        /// инициализирует некоторые значения при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enumerations_Load(object sender, EventArgs e)
        {
            EnumsListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// изменяет размер элементов при изменении размеров формы 
        /// </summary>
        /// <param name="sender">Ennumerations</param>
        /// <param name="e"></param>
        private void Enumerations_SizeChanged(object sender, EventArgs e)
        {
            int listBoxWidth = this.Width * 18 / 53;
            int listBoxHeight = this.Height - 50;

            EnumsListBox.Width = listBoxWidth;
            EnumsListBox.Height = listBoxHeight;
            ValuesListBox.Width = listBoxWidth;
            ValuesListBox.Height = listBoxHeight;

            ValuesListBox.Left = EnumsListBox.Width + 9;
            IntValue.Left = ValuesListBox.Left + ValuesListBox.Width + 3;
            label2.Left = ValuesListBox.Left;
            label3.Left = IntValue.Left;
        }

        /// <summary>
        /// получает выбранный Enum
        /// </summary>
        /// <returns>Type, если элемента нет - null</returns>
        private Type? GetSelectedEnum()
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
        /// при выборе Enum удаляет и меняет значения ValueListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">выбор нового элемента в EnumsListBox</param>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type selectedEnum = GetSelectedEnum();
            if (selectedEnum == null)
            {
                ValuesListBox.Items.Add("Элементы не найдены");
                return;
            }

            ValuesListBox.DataSource = Enum.GetValues(selectedEnum);
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

            IntValue.Text = $"{(int)Enum.Parse(selectedEnum, SelectedValue)}";
        }

    }
}
