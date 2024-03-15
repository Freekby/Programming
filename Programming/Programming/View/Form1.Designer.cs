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
            MainTabControl = new TabControl();
            EnumsPage = new TabPage();
            EnumerationsGroup = new GroupBox();
            SeasonGroupBox = new GroupBox();
            GoButton = new Button();
            SeasonsComboBox = new ComboBox();
            label5 = new Label();
            WeekdayGroupBox = new GroupBox();
            WeekdayTextBox = new TextBox();
            WeekdayParsingButton = new Button();
            ParsedWeekdayLabel = new Label();
            label4 = new Label();
            EnumsListBox = new ListBox();
            label3 = new Label();
            label1 = new Label();
            IntValue = new TextBox();
            label2 = new Label();
            ValuesListBox = new ListBox();
            ClassesPage = new TabPage();
            ClassesGroupBox = new GroupBox();
            RectanglesGroupBox = new GroupBox();
            FindRectangleButton = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            LenghtTextBox = new TextBox();
            WidthTextBox = new TextBox();
            ColorTextBox = new TextBox();
            RectanglesListBox = new ListBox();
            MainTabControl.SuspendLayout();
            EnumsPage.SuspendLayout();
            EnumerationsGroup.SuspendLayout();
            SeasonGroupBox.SuspendLayout();
            WeekdayGroupBox.SuspendLayout();
            ClassesPage.SuspendLayout();
            ClassesGroupBox.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(EnumsPage);
            MainTabControl.Controls.Add(ClassesPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(800, 392);
            MainTabControl.TabIndex = 0;
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
            EnumerationsGroup.Controls.Add(SeasonGroupBox);
            EnumerationsGroup.Controls.Add(WeekdayGroupBox);
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
            // SeasonGroupBox
            // 
            SeasonGroupBox.Controls.Add(GoButton);
            SeasonGroupBox.Controls.Add(SeasonsComboBox);
            SeasonGroupBox.Controls.Add(label5);
            SeasonGroupBox.Location = new Point(392, 212);
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.Size = new Size(394, 140);
            SeasonGroupBox.TabIndex = 1;
            SeasonGroupBox.TabStop = false;
            SeasonGroupBox.Text = "Season Handle";
            // 
            // GoButton
            // 
            GoButton.Location = new Point(133, 38);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(58, 23);
            GoButton.TabIndex = 2;
            GoButton.Text = "Go";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // SeasonsComboBox
            // 
            SeasonsComboBox.FormattingEnabled = true;
            SeasonsComboBox.Location = new Point(6, 37);
            SeasonsComboBox.Name = "SeasonsComboBox";
            SeasonsComboBox.Size = new Size(121, 23);
            SeasonsComboBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 0;
            label5.Text = "Choose season";
            // 
            // WeekdayGroupBox
            // 
            WeekdayGroupBox.Controls.Add(WeekdayTextBox);
            WeekdayGroupBox.Controls.Add(WeekdayParsingButton);
            WeekdayGroupBox.Controls.Add(ParsedWeekdayLabel);
            WeekdayGroupBox.Controls.Add(label4);
            WeekdayGroupBox.Location = new Point(6, 212);
            WeekdayGroupBox.Name = "WeekdayGroupBox";
            WeekdayGroupBox.Size = new Size(380, 140);
            WeekdayGroupBox.TabIndex = 7;
            WeekdayGroupBox.TabStop = false;
            WeekdayGroupBox.Text = "Weekday parsing";
            // 
            // WeekdayTextBox
            // 
            WeekdayTextBox.Location = new Point(6, 38);
            WeekdayTextBox.Name = "WeekdayTextBox";
            WeekdayTextBox.Size = new Size(127, 23);
            WeekdayTextBox.TabIndex = 8;
            // 
            // WeekdayParsingButton
            // 
            WeekdayParsingButton.Location = new Point(139, 38);
            WeekdayParsingButton.Name = "WeekdayParsingButton";
            WeekdayParsingButton.Size = new Size(75, 23);
            WeekdayParsingButton.TabIndex = 8;
            WeekdayParsingButton.Text = "Parse";
            WeekdayParsingButton.UseVisualStyleBackColor = true;
            WeekdayParsingButton.Click += WeekdayParsingButton_Click;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 0;
            label4.Text = "Type value for parsing ";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Color", "Season", "Weekday", "EducationForm", "Genre", "Manufacture" });
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
            // ClassesPage
            // 
            ClassesPage.Controls.Add(ClassesGroupBox);
            ClassesPage.Location = new Point(4, 24);
            ClassesPage.Name = "ClassesPage";
            ClassesPage.Padding = new Padding(3);
            ClassesPage.Size = new Size(792, 364);
            ClassesPage.TabIndex = 1;
            ClassesPage.Text = "Classes";
            ClassesPage.UseVisualStyleBackColor = true;
            // 
            // ClassesGroupBox
            // 
            ClassesGroupBox.Controls.Add(RectanglesGroupBox);
            ClassesGroupBox.Dock = DockStyle.Fill;
            ClassesGroupBox.Location = new Point(3, 3);
            ClassesGroupBox.Name = "ClassesGroupBox";
            ClassesGroupBox.Size = new Size(786, 358);
            ClassesGroupBox.TabIndex = 0;
            ClassesGroupBox.TabStop = false;
            ClassesGroupBox.Text = "Classes";
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(FindRectangleButton);
            RectanglesGroupBox.Controls.Add(label8);
            RectanglesGroupBox.Controls.Add(label7);
            RectanglesGroupBox.Controls.Add(label6);
            RectanglesGroupBox.Controls.Add(LenghtTextBox);
            RectanglesGroupBox.Controls.Add(WidthTextBox);
            RectanglesGroupBox.Controls.Add(ColorTextBox);
            RectanglesGroupBox.Controls.Add(RectanglesListBox);
            RectanglesGroupBox.Location = new Point(3, 19);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(348, 284);
            RectanglesGroupBox.TabIndex = 0;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // FindRectangleButton
            // 
            FindRectangleButton.Location = new Point(202, 243);
            FindRectangleButton.Name = "FindRectangleButton";
            FindRectangleButton.Size = new Size(100, 23);
            FindRectangleButton.TabIndex = 7;
            FindRectangleButton.Text = "Find";
            FindRectangleButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(202, 107);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 6;
            label8.Text = "Color";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(202, 63);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 5;
            label7.Text = "Width";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 22);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 4;
            label6.Text = "Lenght";
            // 
            // LenghtTextBox
            // 
            LenghtTextBox.Location = new Point(202, 40);
            LenghtTextBox.Name = "LenghtTextBox";
            LenghtTextBox.Size = new Size(100, 23);
            LenghtTextBox.TabIndex = 3;
            LenghtTextBox.TextChanged += LenghtTextBox_TextChanged;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(202, 81);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(100, 23);
            WidthTextBox.TabIndex = 2;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(202, 125);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(100, 23);
            ColorTextBox.TabIndex = 1;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Items.AddRange(new object[] { "Rectagle1", "Rectagle2", "Rectagle3", "Rectagle4", "Rectagle5" });
            RectanglesListBox.Location = new Point(6, 22);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(190, 244);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 392);
            Controls.Add(MainTabControl);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Main window";
            Load += MainForm_Load;
            MainTabControl.ResumeLayout(false);
            EnumsPage.ResumeLayout(false);
            EnumerationsGroup.ResumeLayout(false);
            EnumerationsGroup.PerformLayout();
            SeasonGroupBox.ResumeLayout(false);
            SeasonGroupBox.PerformLayout();
            WeekdayGroupBox.ResumeLayout(false);
            WeekdayGroupBox.PerformLayout();
            ClassesPage.ResumeLayout(false);
            ClassesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage EnumsPage;
        private TabPage tabPage2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox IntValue;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private GroupBox EnumerationsGroup;
        private GroupBox WeekdayGroupBox;
        private TextBox WeekdayTextBox;
        private Button WeekdayParsingButton;
        private Label ParsedWeekdayLabel;
        private Label label4;
        private GroupBox SeasonGroupBox;
        private Label label5;
        private ComboBox SeasonsComboBox;
        private Button GoButton;
        private TabPage ClassesPage;
        private GroupBox ClassesGroupBox;
        private GroupBox RectanglesGroupBox;
        private Button FindRectangleButton;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox LenghtTextBox;
        private TextBox WidthTextBox;
        private TextBox ColorTextBox;
        private ListBox RectanglesListBox;
    }
}