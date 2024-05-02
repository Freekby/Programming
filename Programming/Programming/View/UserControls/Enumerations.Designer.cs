namespace Programming.View
{
    partial class Enumerations
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
            EnumerationsInfoGroupBox = new GroupBox();
            EnumsListBox = new ListBox();
            label3 = new Label();
            label1 = new Label();
            IntValue = new TextBox();
            label2 = new Label();
            ValuesListBox = new ListBox();
            EnumerationsInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EnumerationsInfoGroupBox
            // 
            EnumerationsInfoGroupBox.Controls.Add(EnumsListBox);
            EnumerationsInfoGroupBox.Controls.Add(label3);
            EnumerationsInfoGroupBox.Controls.Add(label1);
            EnumerationsInfoGroupBox.Controls.Add(IntValue);
            EnumerationsInfoGroupBox.Controls.Add(label2);
            EnumerationsInfoGroupBox.Controls.Add(ValuesListBox);
            EnumerationsInfoGroupBox.Dock = DockStyle.Fill;
            EnumerationsInfoGroupBox.Location = new Point(0, 0);
            EnumerationsInfoGroupBox.Name = "EnumerationsInfoGroupBox";
            EnumerationsInfoGroupBox.Size = new Size(530, 190);
            EnumerationsInfoGroupBox.TabIndex = 1;
            EnumerationsInfoGroupBox.TabStop = false;
            EnumerationsInfoGroupBox.Text = "Enumerations info";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Color", "Season", "Weekday", "EducationForm", "Genre", "Manufacture" });
            EnumsListBox.Location = new Point(6, 36);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(180, 139);
            EnumsListBox.TabIndex = 7;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(385, 19);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 12;
            label3.Text = "Int value";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 10;
            label1.Text = "Select enumeration";
            // 
            // IntValue
            // 
            IntValue.Location = new Point(385, 37);
            IntValue.Name = "IntValue";
            IntValue.ReadOnly = true;
            IntValue.Size = new Size(139, 23);
            IntValue.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(199, 18);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 11;
            label2.Text = "Select value";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(199, 36);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(180, 139);
            ValuesListBox.TabIndex = 8;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // Enumerations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EnumerationsInfoGroupBox);
            MinimumSize = new Size(530, 190);
            Name = "Enumerations";
            Size = new Size(530, 190);
            Load += Enumerations_Load;
            SizeChanged += Enumerations_SizeChanged;
            EnumerationsInfoGroupBox.ResumeLayout(false);
            EnumerationsInfoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EnumerationsInfoGroupBox;
        private ListBox EnumsListBox;
        private Label label3;
        private Label label1;
        private TextBox IntValue;
        private Label label2;
        private ListBox ValuesListBox;
    }
}
