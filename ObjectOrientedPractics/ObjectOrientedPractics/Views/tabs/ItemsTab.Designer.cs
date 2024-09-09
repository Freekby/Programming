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
            SelectedItemGroupBox = new GroupBox();
            ItemsListBox = new ListBox();
            AddItemButton = new Button();
            RemoveItemButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ItemIDTextBox = new TextBox();
            ItemCostTextBox = new TextBox();
            ItemNameTextBox = new TextBox();
            ItemDescriptionTextBox = new TextBox();
            ItemsGroupBox.SuspendLayout();
            SelectedItemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Controls.Add(RemoveItemButton);
            ItemsGroupBox.Controls.Add(AddItemButton);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Location = new Point(3, 3);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(195, 429);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // SelectedItemGroupBox
            // 
            SelectedItemGroupBox.Controls.Add(ItemDescriptionTextBox);
            SelectedItemGroupBox.Controls.Add(ItemNameTextBox);
            SelectedItemGroupBox.Controls.Add(ItemCostTextBox);
            SelectedItemGroupBox.Controls.Add(ItemIDTextBox);
            SelectedItemGroupBox.Controls.Add(label4);
            SelectedItemGroupBox.Controls.Add(label3);
            SelectedItemGroupBox.Controls.Add(label2);
            SelectedItemGroupBox.Controls.Add(label1);
            SelectedItemGroupBox.Location = new Point(204, 3);
            SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            SelectedItemGroupBox.Size = new Size(319, 429);
            SelectedItemGroupBox.TabIndex = 0;
            SelectedItemGroupBox.TabStop = false;
            SelectedItemGroupBox.Text = "Selected item";
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(6, 19);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(183, 364);
            ItemsListBox.TabIndex = 0;
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(6, 389);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(90, 34);
            AddItemButton.TabIndex = 1;
            AddItemButton.Text = "Add item";
            AddItemButton.UseVisualStyleBackColor = true;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Location = new Point(99, 389);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(90, 34);
            RemoveItemButton.TabIndex = 2;
            RemoveItemButton.Text = "Remove item";
            RemoveItemButton.UseVisualStyleBackColor = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 74);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 181);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Description";
            // 
            // ItemIDTextBox
            // 
            ItemIDTextBox.Location = new Point(50, 16);
            ItemIDTextBox.Name = "ItemIDTextBox";
            ItemIDTextBox.Size = new Size(100, 23);
            ItemIDTextBox.TabIndex = 4;
            // 
            // ItemCostTextBox
            // 
            ItemCostTextBox.Location = new Point(50, 45);
            ItemCostTextBox.Name = "ItemCostTextBox";
            ItemCostTextBox.Size = new Size(100, 23);
            ItemCostTextBox.TabIndex = 5;
            // 
            // ItemNameTextBox
            // 
            ItemNameTextBox.Location = new Point(6, 92);
            ItemNameTextBox.Multiline = true;
            ItemNameTextBox.Name = "ItemNameTextBox";
            ItemNameTextBox.Size = new Size(307, 86);
            ItemNameTextBox.TabIndex = 6;
            // 
            // ItemDescriptionTextBox
            // 
            ItemDescriptionTextBox.Location = new Point(6, 199);
            ItemDescriptionTextBox.Multiline = true;
            ItemDescriptionTextBox.Name = "ItemDescriptionTextBox";
            ItemDescriptionTextBox.Size = new Size(307, 122);
            ItemDescriptionTextBox.TabIndex = 7;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedItemGroupBox);
            Controls.Add(ItemsGroupBox);
            Name = "ItemsTab";
            Size = new Size(526, 435);
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
    }
}
