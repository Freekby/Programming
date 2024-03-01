namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            EnumsPage = new TabPage();
            EnumerationsGroup = new GroupBox();
            EnumsListBox = new ListBox();
            label3 = new Label();
            label1 = new Label();
            IntValue = new TextBox();
            label2 = new Label();
            ValuesListBox = new ListBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            ParsedWeekdayLabel = new Label();
            WeekdayParsingButton = new Button();
            WeekdayTextBox = new TextBox();
            tabControl1.SuspendLayout();
            EnumsPage.SuspendLayout();
            EnumerationsGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(EnumsPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 392);
            tabControl1.TabIndex = 0;
            // 
            // EnumsPage
            // 
            EnumsPage.Controls.Add(EnumerationsGroup);
            EnumsPage.Location = new Point(4, 24);
            EnumsPage.Name = "EnumsPage";
            EnumsPage.Padding = new Padding(3);
            EnumsPage.Size = new Size(792, 364);
            EnumsPage.TabIndex = 0;
            EnumsPage.Text = "Enums";
            EnumsPage.ToolTipText = "Enumeratoins ";
            EnumsPage.UseVisualStyleBackColor = true;
            // 
            // EnumerationsGroup
            // 
            EnumerationsGroup.Controls.Add(groupBox1);
            EnumerationsGroup.Controls.Add(EnumsListBox);
            EnumerationsGroup.Controls.Add(label3);
            EnumerationsGroup.Controls.Add(label1);
            EnumerationsGroup.Controls.Add(IntValue);
            EnumerationsGroup.Controls.Add(label2);
            EnumerationsGroup.Controls.Add(ValuesListBox);
            EnumerationsGroup.Dock = DockStyle.Fill;
            EnumerationsGroup.Location = new Point(3, 3);
            EnumerationsGroup.Name = "EnumerationsGroup";
            EnumerationsGroup.Size = new Size(786, 358);
            EnumerationsGroup.TabIndex = 7;
            EnumerationsGroup.TabStop = false;
            EnumerationsGroup.Text = "Enumerations";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Location = new Point(6, 37);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(187, 169);
            EnumsListBox.TabIndex = 1;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 19);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 6;
            label3.Text = "Int value";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 4;
            label1.Text = "Select enumeration";
            // 
            // IntValue
            // 
            IntValue.Location = new Point(392, 37);
            IntValue.Name = "IntValue";
            IntValue.ReadOnly = true;
            IntValue.Size = new Size(120, 23);
            IntValue.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 19);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 5;
            label2.Text = "Select value";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(199, 37);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(187, 169);
            ValuesListBox.TabIndex = 2;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(WeekdayTextBox);
            groupBox1.Controls.Add(WeekdayParsingButton);
            groupBox1.Controls.Add(ParsedWeekdayLabel);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(6, 212);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(380, 140);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Weekday parsing";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 0;
            label4.Text = "Type value for parsing ";
            // 
            // ParsedWeekdayLabel
            // 
            ParsedWeekdayLabel.AutoSize = true;
            ParsedWeekdayLabel.Location = new Point(6, 63);
            ParsedWeekdayLabel.Name = "ParsedWeekdayLabel";
            ParsedWeekdayLabel.Size = new Size(103, 15);
            ParsedWeekdayLabel.TabIndex = 1;
            ParsedWeekdayLabel.Text = "Здесь будет ответ";
            // 
            // WeekdayParsingButton
            // 
            WeekdayParsingButton.Location = new Point(139, 37);
            WeekdayParsingButton.Name = "WeekdayParsingButton";
            WeekdayParsingButton.Size = new Size(75, 23);
            WeekdayParsingButton.TabIndex = 8;
            WeekdayParsingButton.Text = "Parse";
            WeekdayParsingButton.UseVisualStyleBackColor = true;
            WeekdayParsingButton.Click += WeekdayParsingButton_Click;
            // 
            // WeekdayTextBox
            // 
            WeekdayTextBox.Location = new Point(6, 37);
            WeekdayTextBox.Name = "WeekdayTextBox";
            WeekdayTextBox.Size = new Size(127, 23);
            WeekdayTextBox.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 392);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Main window";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            EnumsPage.ResumeLayout(false);
            EnumerationsGroup.ResumeLayout(false);
            EnumerationsGroup.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage EnumsPage;
        private TabPage tabPage2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox IntValue;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private GroupBox EnumerationsGroup;
        private GroupBox groupBox1;
        private TextBox WeekdayTextBox;
        private Button WeekdayParsingButton;
        private Label ParsedWeekdayLabel;
        private Label label4;
    }
}