using ObjectOrientedPractices.Models.Enums;

namespace ObjectOrientedPractices.Views.Forms
{
    public partial class AddDiscountForm : Form
    {
        public Category SelectedCategory { get; private set; }

        public AddDiscountForm()
        {
            InitializeComponent();
        }

        private void AddDiscountForm_Load(object sender, EventArgs e)
        {
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            CategoryComboBox.SelectedIndex = 0;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            SelectedCategory = (Category)CategoryComboBox.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
