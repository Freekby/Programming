namespace Programming.View
{
    public partial class SeasonHandler : UserControl
    {
        public SeasonHandler()
        {
            InitializeComponent();
        }

        /// <summary>
        /// инициализирует некоторые значения при загрузке формы
        /// </summary>
        /// <param name="sender">sea</param>
        /// <param name="e">SeasonHandler</param>
        private void SeasonHandler_Load(object sender, EventArgs e)
        {
            SeasonsComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonsComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// изменяет рзмер элементов при изменении размера формы
        /// </summary>
        /// <param name="sender"> SeasonHandleGroupBox</param>
        /// <param name="e"></param>
        private void SeasonHandleGroupBox_SizeChanged(object sender, EventArgs e)
        {
            SeasonsComboBox.Width = this.Width - 87;
            GoButton.Left = this.Width - 78;
        }

        /// <summary>
        /// вызывает событие в зависимости от выбранного элемента SeasonsComboBox
        /// </summary>
        /// <param name="sender">GoButton</param>
        /// <param name="e"></param>
        private void GoButton_Click(object sender, EventArgs e)
        {
            Season currentSeason = (Season)SeasonsComboBox.SelectedItem;
            switch (currentSeason)
            {
                case Season.Winter:
                    MessageBox.Show("зима");
                    break;
                case Season.Spring:
                    MessageBox.Show("весна");
                    break;
                case Season.Summer:
                    MessageBox.Show("лето");
                    break;
                case Season.Autmn:
                    MessageBox.Show("осень");
                    break;
            }
        }
    }
}
