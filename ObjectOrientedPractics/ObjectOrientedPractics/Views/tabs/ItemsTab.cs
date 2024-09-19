using System.ComponentModel;

namespace ObjectOrientedPractices.Views.tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new();
        private Item _currentItem;
        bool isAllOk = true;

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
            if (!isAllOk)
            {
                ItemsListBox.SelectedItem = _currentItem;
                return;
            }

            if (ItemsListBox.SelectedItem is null) { return; }
            _currentItem = ItemsListBox.SelectedItem as Item;

            ItemIDTextBox.Text = _currentItem.Id.ToString();
            ItemCostTextBox.Text = _currentItem.Cost.ToString();
            ItemNameTextBox.Text = _currentItem.Name.ToString();
            ItemDescriptionTextBox.Text = _currentItem.Info.ToString();

            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
        }

        private void ItemsListBox_Click(object sender, EventArgs e)
        {
            isAllOk = true;

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
                isAllOk = false;
            }
            try
            {
                string name = ItemNameTextBox.Text;
                _currentItem.Name = name;
            }
            catch (Exception)
            {
                ItemNameTextBox.BackColor = Color.LightPink;
                isAllOk = false;
            }
            try
            {
                string info = ItemDescriptionTextBox.Text;
                _currentItem.Info = info;
            }
            catch (Exception)
            {
                ItemDescriptionTextBox.BackColor = Color.LightPink;
                isAllOk = false;
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
