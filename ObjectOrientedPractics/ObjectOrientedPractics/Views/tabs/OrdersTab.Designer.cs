namespace ObjectOrientedPractices.Views.tabs
{
    partial class OrdersTab
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
            components = new System.ComponentModel.Container();
            Address address1 = new Address();
            OrdersDataGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            IdTextBox = new TextBox();
            DateTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            OrderItemsListBox = new ListBox();
            label7 = new Label();
            addressControl1 = new Controls.AddressControl();
            AmountLabel = new Label();
            OrderDataBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.AllowUserToResizeColumns = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Location = new Point(4, 31);
            OrdersDataGridView.Margin = new Padding(4, 3, 4, 3);
            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.Size = new Size(394, 513);
            OrdersDataGridView.TabIndex = 0;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(4, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 13);
            label1.TabIndex = 1;
            label1.Text = "Orders";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(411, 13);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 13);
            label2.TabIndex = 3;
            label2.Text = "Selected Order";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(411, 45);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 4;
            label3.Text = "ID:";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(479, 42);
            IdTextBox.Margin = new Padding(4, 3, 4, 3);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(140, 23);
            IdTextBox.TabIndex = 5;
            // 
            // DateTextBox
            // 
            DateTextBox.Location = new Point(479, 72);
            DateTextBox.Margin = new Padding(4, 3, 4, 3);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.Size = new Size(140, 23);
            DateTextBox.TabIndex = 6;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(479, 102);
            StatusComboBox.Margin = new Padding(4, 3, 4, 3);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(140, 23);
            StatusComboBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(411, 105);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 8;
            label4.Text = "Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(411, 75);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "Created:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(411, 300);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 13);
            label6.TabIndex = 10;
            label6.Text = "Order Items";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 15;
            OrderItemsListBox.Location = new Point(414, 318);
            OrderItemsListBox.Margin = new Padding(4, 3, 4, 3);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(644, 139);
            OrderItemsListBox.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(411, 460);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(53, 13);
            label7.TabIndex = 24;
            label7.Text = "Amount:";
            // 
            // addressControl1
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            addressControl1.Address = address1;
            addressControl1.Location = new Point(414, 133);
            addressControl1.Margin = new Padding(4, 3, 4, 3);
            addressControl1.MinimumSize = new Size(642, 162);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(642, 164);
            addressControl1.TabIndex = 11;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(411, 473);
            AmountLabel.Margin = new Padding(4, 0, 4, 0);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(45, 25);
            AmountLabel.TabIndex = 26;
            AmountLabel.Text = "0.0";
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AmountLabel);
            Controls.Add(OrderItemsListBox);
            Controls.Add(label7);
            Controls.Add(addressControl1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(StatusComboBox);
            Controls.Add(DateTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OrdersDataGridView);
            Margin = new Padding(4, 3, 4, 3);
            Name = "OrdersTab";
            Size = new Size(1063, 553);
            Load += OrdersTab_Load;
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderDataBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Controls.AddressControl addressControl1;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private Label AmountLabel;
        private BindingSource OrderDataBindingSource;
    }
}
