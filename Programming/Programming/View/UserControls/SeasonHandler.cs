namespace Programming.View
{
    public partial class SeasonHandler : UserControl
    {
        public SeasonHandler()
        {
            InitializeComponent();
        }

        private void SeasonHandler_Load(object sender, EventArgs e)
        {
            SeasonsComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonsComboBox.SelectedIndex = 0;
        }

        private void SeasonHandleGroupBox_SizeChanged(object sender, EventArgs e)
        {
            SeasonsComboBox.Width = this.Width - 87;
            GoButton.Left = this.Width - 78;
        }

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
                    GoButton.BackColor = System.Drawing.Color.Black;
                    break;
                case Season.Autmn:
                    MessageBox.Show("осень");
                    break;
            }
        }
    }
}
