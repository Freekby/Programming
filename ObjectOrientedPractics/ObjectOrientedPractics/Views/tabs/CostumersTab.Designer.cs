namespace ObjectOrientedPractices.Views.tabs
{
    partial class CostumersTab
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
            CostumersGroupBox = new GroupBox();
            RemoveCostumerButton = new Button();
            AddCostumerButton = new Button();
            CostumersListBox = new ListBox();
            SelectedCostumerGroupBox = new GroupBox();
            CostumerDescriptionTextBox = new TextBox();
            CostumerNameTextBox = new TextBox();
            CostumerCostTextBox = new TextBox();
            CostumerIDTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CostumersGroupBox.SuspendLayout();
            SelectedCostumerGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CostumersGroupBox
            // 
            CostumersGroupBox.Controls.Add(RemoveCostumerButton);
            CostumersGroupBox.Controls.Add(AddCostumerButton);
            CostumersGroupBox.Controls.Add(CostumersListBox);
            CostumersGroupBox.Location = new Point(3, 3);
            CostumersGroupBox.Name = "CostumersGroupBox";
            CostumersGroupBox.Size = new Size(246, 429);
            CostumersGroupBox.TabIndex = 1;
            CostumersGroupBox.TabStop = false;
            CostumersGroupBox.Text = "Costumers";
            // 
            // RemoveCostumerButton
            // 
            RemoveCostumerButton.Location = new Point(126, 389);
            RemoveCostumerButton.Name = "RemoveCostumerButton";
            RemoveCostumerButton.Size = new Size(114, 34);
            RemoveCostumerButton.TabIndex = 2;
            RemoveCostumerButton.Text = "Remove Costumer";
            RemoveCostumerButton.UseVisualStyleBackColor = true;
            // 
            // AddCostumerButton
            // 
            AddCostumerButton.Location = new Point(6, 389);
            AddCostumerButton.Name = "AddCostumerButton";
            AddCostumerButton.Size = new Size(114, 34);
            AddCostumerButton.TabIndex = 1;
            AddCostumerButton.Text = "Add Costumer";
            AddCostumerButton.UseVisualStyleBackColor = true;
            // 
            // CostumersListBox
            // 
            CostumersListBox.FormattingEnabled = true;
            CostumersListBox.ItemHeight = 15;
            CostumersListBox.Location = new Point(6, 19);
            CostumersListBox.Name = "CostumersListBox";
            CostumersListBox.Size = new Size(234, 364);
            CostumersListBox.TabIndex = 0;
            // 
            // SelectedCostumerGroupBox
            // 
            SelectedCostumerGroupBox.Controls.Add(CostumerDescriptionTextBox);
            SelectedCostumerGroupBox.Controls.Add(CostumerNameTextBox);
            SelectedCostumerGroupBox.Controls.Add(CostumerCostTextBox);
            SelectedCostumerGroupBox.Controls.Add(CostumerIDTextBox);
            SelectedCostumerGroupBox.Controls.Add(label4);
            SelectedCostumerGroupBox.Controls.Add(label3);
            SelectedCostumerGroupBox.Controls.Add(label2);
            SelectedCostumerGroupBox.Controls.Add(label1);
            SelectedCostumerGroupBox.Location = new Point(255, 3);
            SelectedCostumerGroupBox.Name = "SelectedCostumerGroupBox";
            SelectedCostumerGroupBox.Size = new Size(325, 429);
            SelectedCostumerGroupBox.TabIndex = 2;
            SelectedCostumerGroupBox.TabStop = false;
            SelectedCostumerGroupBox.Text = "Selected costumer";
            // 
            // CostumerDescriptionTextBox
            // 
            CostumerDescriptionTextBox.Location = new Point(6, 199);
            CostumerDescriptionTextBox.Multiline = true;
            CostumerDescriptionTextBox.Name = "CostumerDescriptionTextBox";
            CostumerDescriptionTextBox.Size = new Size(307, 122);
            CostumerDescriptionTextBox.TabIndex = 7;
            // 
            // CostumerNameTextBox
            // 
            CostumerNameTextBox.Location = new Point(6, 92);
            CostumerNameTextBox.Multiline = true;
            CostumerNameTextBox.Name = "CostumerNameTextBox";
            CostumerNameTextBox.Size = new Size(307, 86);
            CostumerNameTextBox.TabIndex = 6;
            // 
            // CostumerCostTextBox
            // 
            CostumerCostTextBox.Location = new Point(50, 45);
            CostumerCostTextBox.Name = "CostumerCostTextBox";
            CostumerCostTextBox.Size = new Size(100, 23);
            CostumerCostTextBox.TabIndex = 5;
            // 
            // CostumerIDTextBox
            // 
            CostumerIDTextBox.Location = new Point(50, 16);
            CostumerIDTextBox.Name = "CostumerIDTextBox";
            CostumerIDTextBox.Size = new Size(100, 23);
            CostumerIDTextBox.TabIndex = 4;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 74);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Name";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // CostumersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedCostumerGroupBox);
            Controls.Add(CostumersGroupBox);
            Name = "CostumersTab";
            Size = new Size(584, 436);
            CostumersGroupBox.ResumeLayout(false);
            SelectedCostumerGroupBox.ResumeLayout(false);
            SelectedCostumerGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CostumersGroupBox;
        private Button RemoveCostumerButton;
        private Button AddCostumerButton;
        private ListBox CostumersListBox;
        private GroupBox SelectedCostumerGroupBox;
        private TextBox CostumerDescriptionTextBox;
        private TextBox CostumerNameTextBox;
        private TextBox CostumerCostTextBox;
        private TextBox CostumerIDTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
