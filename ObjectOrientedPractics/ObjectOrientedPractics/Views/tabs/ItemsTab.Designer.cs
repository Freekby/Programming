namespace ObjectOrientedPractices.Views.tabs
{
    partial class ItemsTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ItemsGroupBox = new GroupBox();
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            ItemsListBox = new ListBox();
            SelectedItemGroupBox = new GroupBox();
            ItemCategoryComboBox = new ComboBox();
            label5 = new Label();
            ItemDescriptionTextBox = new TextBox();
            ItemNameTextBox = new TextBox();
            ItemCostTextBox = new TextBox();
            ItemIDTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ItemsGroupBox.SuspendLayout();
            SelectedItemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsGroupBox.Controls.Add(RemoveItemButton);
            ItemsGroupBox.Controls.Add(AddItemButton);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Location = new Point(3, 3);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(246, 327);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveItemButton.Location = new Point(126, 287);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(114, 34);
            RemoveItemButton.TabIndex = 2;
            RemoveItemButton.Text = "Remove item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemButton.Location = new Point(6, 287);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(114, 34);
            AddItemButton.TabIndex = 1;
            AddItemButton.Text = "Add item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(6, 19);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(234, 259);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.Click += ItemsListBox_Click;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // SelectedItemGroupBox
            // 
            SelectedItemGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedItemGroupBox.Controls.Add(ItemCategoryComboBox);
            SelectedItemGroupBox.Controls.Add(label5);
            SelectedItemGroupBox.Controls.Add(ItemDescriptionTextBox);
            SelectedItemGroupBox.Controls.Add(ItemNameTextBox);
            SelectedItemGroupBox.Controls.Add(ItemCostTextBox);
            SelectedItemGroupBox.Controls.Add(ItemIDTextBox);
            SelectedItemGroupBox.Controls.Add(label4);
            SelectedItemGroupBox.Controls.Add(label3);
            SelectedItemGroupBox.Controls.Add(label2);
            SelectedItemGroupBox.Controls.Add(label1);
            SelectedItemGroupBox.Location = new Point(255, 3);
            SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            SelectedItemGroupBox.Size = new Size(310, 327);
            SelectedItemGroupBox.TabIndex = 0;
            SelectedItemGroupBox.TabStop = false;
            SelectedItemGroupBox.Text = "Selected item";
            // 
            // ItemCategoryComboBox
            // 
            ItemCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ItemCategoryComboBox.FormattingEnabled = true;
            ItemCategoryComboBox.Location = new Point(67, 79);
            ItemCategoryComboBox.Name = "ItemCategoryComboBox";
            ItemCategoryComboBox.Size = new Size(100, 23);
            ItemCategoryComboBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 82);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 8;
            label5.Text = "Category";
            // 
            // ItemDescriptionTextBox
            // 
            ItemDescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ItemDescriptionTextBox.Location = new Point(6, 230);
            ItemDescriptionTextBox.Multiline = true;
            ItemDescriptionTextBox.Name = "ItemDescriptionTextBox";
            ItemDescriptionTextBox.Size = new Size(298, 89);
            ItemDescriptionTextBox.TabIndex = 7;
            // 
            // ItemNameTextBox
            // 
            ItemNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ItemNameTextBox.Location = new Point(6, 123);
            ItemNameTextBox.Multiline = true;
            ItemNameTextBox.Name = "ItemNameTextBox";
            ItemNameTextBox.Size = new Size(298, 86);
            ItemNameTextBox.TabIndex = 6;
            // 
            // ItemCostTextBox
            // 
            ItemCostTextBox.Location = new Point(67, 45);
            ItemCostTextBox.Name = "ItemCostTextBox";
            ItemCostTextBox.Size = new Size(100, 23);
            ItemCostTextBox.TabIndex = 5;
            // 
            // ItemIDTextBox
            // 
            ItemIDTextBox.Location = new Point(67, 16);
            ItemIDTextBox.Name = "ItemIDTextBox";
            ItemIDTextBox.ReadOnly = true;
            ItemIDTextBox.Size = new Size(100, 23);
            ItemIDTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 212);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 105);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Cost";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(SelectedItemGroupBox);
            Controls.Add(ItemsGroupBox);
            MinimumSize = new Size(570, 333);
            Name = "ItemsTab";
            Size = new Size(570, 333);
            Load += ItemsTab_Load;
            ItemsGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ItemsGroupBox;
        private GroupBox SelectedItemGroupBox;
        private Button RemoveItemButton;
        private Button AddItemButton;
        private ListBox ItemsListBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox ItemDescriptionTextBox;
        private TextBox ItemNameTextBox;
        private TextBox ItemCostTextBox;
        private TextBox ItemIDTextBox;
        private Label label5;
        private ComboBox ItemCategoryComboBox;
    }
}
