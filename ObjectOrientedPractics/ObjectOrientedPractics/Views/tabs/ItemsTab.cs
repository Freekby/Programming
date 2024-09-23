namespace ObjectOrientedPractices.Views.tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// список для хранения всех товаров
        /// </summary>
        private List<Item> _items = new();
        /// <summary>
        /// текущий выбранный товар
        /// </summary>
        private Item _currentItem;
        /// <summary>
        /// true если данные введены корректно, иначе - false 
        /// </summary>
        bool _isDataCorrect = true;

        public ItemsTab()
        {
            InitializeComponent();
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {
            _items.Add(ItemGenerator.Generate());
            _items.Add(ItemGenerator.Generate());
            _items.Add(ItemGenerator.Generate());
            _items.Add(ItemGenerator.Generate());

            ItemsListBox.DataSource = _items;
            ItemsListBox.SelectedIndex = 0;
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is null) { return; }
            if (!_isDataCorrect)
            {
                ItemsListBox.SelectedItem = _currentItem;
                return;
            }

            _currentItem = ItemsListBox.SelectedItem as Item;

            ItemIDTextBox.Text = _currentItem.Id.ToString();
            ItemCostTextBox.Text = _currentItem.Cost.ToString();
            ItemNameTextBox.Text = _currentItem.Name;
            ItemDescriptionTextBox.Text = _currentItem.Info;

            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
        }

        private void ItemsListBox_Click(object sender, EventArgs e)
        {
            _isDataCorrect = true;

            ItemCostTextBox.BackColor = Color.White;
            ItemNameTextBox.BackColor = Color.White;
            ItemDescriptionTextBox.BackColor = Color.White;

            try
            {
                float cost = float.Parse(ItemCostTextBox.Text);
                _currentItem.Cost = cost;
            }
            catch (Exception)
            {
                ItemCostTextBox.BackColor = Color.LightPink;
                _isDataCorrect = false;
            }
            try
            {
                string name = ItemNameTextBox.Text;
                _currentItem.Name = name;
            }
            catch (Exception)
            {
                ItemNameTextBox.BackColor = Color.LightPink;
                _isDataCorrect = false;
            }
            try
            {
                string info = ItemDescriptionTextBox.Text;
                _currentItem.Info = info;
            }
            catch (Exception)
            {
                ItemDescriptionTextBox.BackColor = Color.LightPink;
                _isDataCorrect = false;
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Item newItem = ItemGenerator.Generate();
            _items.Add(newItem);
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            _items.Remove(_currentItem);
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
        }
    }
}
