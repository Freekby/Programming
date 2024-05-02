using Programming.View;

namespace Programming
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            int enumerationsBoxWidth = this.Width / 2 - 22;
            weekdayParsing.Width = enumerationsBoxWidth;
            seasonHandler.Width = enumerationsBoxWidth;
            seasonHandler.Left = enumerationsBoxWidth + 9;
        }
    }
}