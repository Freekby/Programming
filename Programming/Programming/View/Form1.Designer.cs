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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            MoviesGroupBox = new GroupBox();
            label13 = new Label();
            MovieGenreTextBox = new TextBox();
            label12 = new Label();
            MovieTitleTextBox = new TextBox();
            MovieFindButton = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            MovieDurationTextBox = new TextBox();
            MovieReleaseYearTextBox = new TextBox();
            MovieRatingTextBox = new TextBox();
            MovieListBox = new ListBox();
            RectanglesGroupBox = new GroupBox();
            label16 = new Label();
            RectangleIdTextBox = new TextBox();
            label15 = new Label();
            label14 = new Label();
            RectangleCenterYTextBox = new TextBox();
            RectangleCenterXTextBox = new TextBox();
            RectangleFindButton = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            RectagleLenghtTextBox = new TextBox();
            RectangleWidthTextBox = new TextBox();
            RectangleColorTextBox = new TextBox();
            RectanglesListBox = new ListBox();
            RectangleTabPage = new TabPage();
            panel1 = new Panel();
            MainTabControl.SuspendLayout();
            EnumsPage.SuspendLayout();
            EnumerationsGroup.SuspendLayout();
            SeasonGroupBox.SuspendLayout();
            WeekdayGroupBox.SuspendLayout();
            ClassesPage.SuspendLayout();
            ClassesGroupBox.SuspendLayout();
            MoviesGroupBox.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            RectangleTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(EnumsPage);
            MainTabControl.Controls.Add(ClassesPage);
            MainTabControl.Controls.Add(RectangleTabPage);
            resources.ApplyResources(MainTabControl, "MainTabControl");
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.SelectedIndexChanged += MainTabControl_SelectedIndexChanged;
            // 
            // EnumsPage
            // 
            EnumsPage.Controls.Add(EnumerationsGroup);
            resources.ApplyResources(EnumsPage, "EnumsPage");
            EnumsPage.Name = "EnumsPage";
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
            resources.ApplyResources(EnumerationsGroup, "EnumerationsGroup");
            EnumerationsGroup.Name = "EnumerationsGroup";
            EnumerationsGroup.TabStop = false;
            // 
            // SeasonGroupBox
            // 
            SeasonGroupBox.Controls.Add(GoButton);
            SeasonGroupBox.Controls.Add(SeasonsComboBox);
            SeasonGroupBox.Controls.Add(label5);
            resources.ApplyResources(SeasonGroupBox, "SeasonGroupBox");
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.TabStop = false;
            // 
            // GoButton
            // 
            resources.ApplyResources(GoButton, "GoButton");
            GoButton.Name = "GoButton";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // SeasonsComboBox
            // 
            SeasonsComboBox.FormattingEnabled = true;
            resources.ApplyResources(SeasonsComboBox, "SeasonsComboBox");
            SeasonsComboBox.Name = "SeasonsComboBox";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // WeekdayGroupBox
            // 
            WeekdayGroupBox.Controls.Add(WeekdayTextBox);
            WeekdayGroupBox.Controls.Add(WeekdayParsingButton);
            WeekdayGroupBox.Controls.Add(ParsedWeekdayLabel);
            WeekdayGroupBox.Controls.Add(label4);
            resources.ApplyResources(WeekdayGroupBox, "WeekdayGroupBox");
            WeekdayGroupBox.Name = "WeekdayGroupBox";
            WeekdayGroupBox.TabStop = false;
            // 
            // WeekdayTextBox
            // 
            resources.ApplyResources(WeekdayTextBox, "WeekdayTextBox");
            WeekdayTextBox.Name = "WeekdayTextBox";
            // 
            // WeekdayParsingButton
            // 
            resources.ApplyResources(WeekdayParsingButton, "WeekdayParsingButton");
            WeekdayParsingButton.Name = "WeekdayParsingButton";
            WeekdayParsingButton.UseVisualStyleBackColor = true;
            WeekdayParsingButton.Click += WeekdayParsingButton_Click;
            // 
            // ParsedWeekdayLabel
            // 
            resources.ApplyResources(ParsedWeekdayLabel, "ParsedWeekdayLabel");
            ParsedWeekdayLabel.Name = "ParsedWeekdayLabel";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            resources.ApplyResources(EnumsListBox, "EnumsListBox");
            EnumsListBox.Items.AddRange(new object[] { resources.GetString("EnumsListBox.Items"), resources.GetString("EnumsListBox.Items1"), resources.GetString("EnumsListBox.Items2"), resources.GetString("EnumsListBox.Items3"), resources.GetString("EnumsListBox.Items4"), resources.GetString("EnumsListBox.Items5") });
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // IntValue
            // 
            resources.ApplyResources(IntValue, "IntValue");
            IntValue.Name = "IntValue";
            IntValue.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            resources.ApplyResources(ValuesListBox, "ValuesListBox");
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // ClassesPage
            // 
            ClassesPage.Controls.Add(ClassesGroupBox);
            resources.ApplyResources(ClassesPage, "ClassesPage");
            ClassesPage.Name = "ClassesPage";
            ClassesPage.UseVisualStyleBackColor = true;
            // 
            // ClassesGroupBox
            // 
            ClassesGroupBox.Controls.Add(MoviesGroupBox);
            ClassesGroupBox.Controls.Add(RectanglesGroupBox);
            resources.ApplyResources(ClassesGroupBox, "ClassesGroupBox");
            ClassesGroupBox.Name = "ClassesGroupBox";
            ClassesGroupBox.TabStop = false;
            // 
            // MoviesGroupBox
            // 
            MoviesGroupBox.Controls.Add(label13);
            MoviesGroupBox.Controls.Add(MovieGenreTextBox);
            MoviesGroupBox.Controls.Add(label12);
            MoviesGroupBox.Controls.Add(MovieTitleTextBox);
            MoviesGroupBox.Controls.Add(MovieFindButton);
            MoviesGroupBox.Controls.Add(label9);
            MoviesGroupBox.Controls.Add(label10);
            MoviesGroupBox.Controls.Add(label11);
            MoviesGroupBox.Controls.Add(MovieDurationTextBox);
            MoviesGroupBox.Controls.Add(MovieReleaseYearTextBox);
            MoviesGroupBox.Controls.Add(MovieRatingTextBox);
            MoviesGroupBox.Controls.Add(MovieListBox);
            resources.ApplyResources(MoviesGroupBox, "MoviesGroupBox");
            MoviesGroupBox.Name = "MoviesGroupBox";
            MoviesGroupBox.TabStop = false;
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.Name = "label13";
            // 
            // MovieGenreTextBox
            // 
            resources.ApplyResources(MovieGenreTextBox, "MovieGenreTextBox");
            MovieGenreTextBox.Name = "MovieGenreTextBox";
            MovieGenreTextBox.TextChanged += MovieGenreTextBox_TextChanged;
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            // 
            // MovieTitleTextBox
            // 
            resources.ApplyResources(MovieTitleTextBox, "MovieTitleTextBox");
            MovieTitleTextBox.Name = "MovieTitleTextBox";
            MovieTitleTextBox.TextChanged += MovieTitleTextBox_TextChanged;
            // 
            // MovieFindButton
            // 
            resources.ApplyResources(MovieFindButton, "MovieFindButton");
            MovieFindButton.Name = "MovieFindButton";
            MovieFindButton.UseVisualStyleBackColor = true;
            MovieFindButton.Click += MovieFindButton_Click;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // MovieDurationTextBox
            // 
            resources.ApplyResources(MovieDurationTextBox, "MovieDurationTextBox");
            MovieDurationTextBox.Name = "MovieDurationTextBox";
            MovieDurationTextBox.TextChanged += MovieDurationTextBox_TextChanged;
            // 
            // MovieReleaseYearTextBox
            // 
            resources.ApplyResources(MovieReleaseYearTextBox, "MovieReleaseYearTextBox");
            MovieReleaseYearTextBox.Name = "MovieReleaseYearTextBox";
            MovieReleaseYearTextBox.TextChanged += MovieReleaseYearTextBox_TextChanged;
            // 
            // MovieRatingTextBox
            // 
            resources.ApplyResources(MovieRatingTextBox, "MovieRatingTextBox");
            MovieRatingTextBox.Name = "MovieRatingTextBox";
            MovieRatingTextBox.TextChanged += MovieRatingTextBox_TextChanged;
            // 
            // MovieListBox
            // 
            MovieListBox.FormattingEnabled = true;
            resources.ApplyResources(MovieListBox, "MovieListBox");
            MovieListBox.Items.AddRange(new object[] { resources.GetString("MovieListBox.Items"), resources.GetString("MovieListBox.Items1"), resources.GetString("MovieListBox.Items2"), resources.GetString("MovieListBox.Items3"), resources.GetString("MovieListBox.Items4") });
            MovieListBox.Name = "MovieListBox";
            MovieListBox.SelectedIndexChanged += MovieListBox_SelectedIndexChanged;
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(label16);
            RectanglesGroupBox.Controls.Add(RectangleIdTextBox);
            RectanglesGroupBox.Controls.Add(label15);
            RectanglesGroupBox.Controls.Add(label14);
            RectanglesGroupBox.Controls.Add(RectangleCenterYTextBox);
            RectanglesGroupBox.Controls.Add(RectangleCenterXTextBox);
            RectanglesGroupBox.Controls.Add(RectangleFindButton);
            RectanglesGroupBox.Controls.Add(label8);
            RectanglesGroupBox.Controls.Add(label7);
            RectanglesGroupBox.Controls.Add(label6);
            RectanglesGroupBox.Controls.Add(RectagleLenghtTextBox);
            RectanglesGroupBox.Controls.Add(RectangleWidthTextBox);
            RectanglesGroupBox.Controls.Add(RectangleColorTextBox);
            RectanglesGroupBox.Controls.Add(RectanglesListBox);
            resources.ApplyResources(RectanglesGroupBox, "RectanglesGroupBox");
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.TabStop = false;
            // 
            // label16
            // 
            resources.ApplyResources(label16, "label16");
            label16.Name = "label16";
            // 
            // RectangleIdTextBox
            // 
            resources.ApplyResources(RectangleIdTextBox, "RectangleIdTextBox");
            RectangleIdTextBox.Name = "RectangleIdTextBox";
            RectangleIdTextBox.ReadOnly = true;
            // 
            // label15
            // 
            resources.ApplyResources(label15, "label15");
            label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.Name = "label14";
            // 
            // RectangleCenterYTextBox
            // 
            resources.ApplyResources(RectangleCenterYTextBox, "RectangleCenterYTextBox");
            RectangleCenterYTextBox.Name = "RectangleCenterYTextBox";
            RectangleCenterYTextBox.ReadOnly = true;
            // 
            // RectangleCenterXTextBox
            // 
            resources.ApplyResources(RectangleCenterXTextBox, "RectangleCenterXTextBox");
            RectangleCenterXTextBox.Name = "RectangleCenterXTextBox";
            RectangleCenterXTextBox.ReadOnly = true;
            // 
            // RectangleFindButton
            // 
            resources.ApplyResources(RectangleFindButton, "RectangleFindButton");
            RectangleFindButton.Name = "RectangleFindButton";
            RectangleFindButton.UseVisualStyleBackColor = true;
            RectangleFindButton.Click += FindRectangleButton_Click;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // RectagleLenghtTextBox
            // 
            resources.ApplyResources(RectagleLenghtTextBox, "RectagleLenghtTextBox");
            RectagleLenghtTextBox.Name = "RectagleLenghtTextBox";
            RectagleLenghtTextBox.TextChanged += RectangleLenghtTextBox_TextChanged;
            // 
            // RectangleWidthTextBox
            // 
            resources.ApplyResources(RectangleWidthTextBox, "RectangleWidthTextBox");
            RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            RectangleWidthTextBox.TextChanged += RectangleWidthTextBox_TextChanged;
            // 
            // RectangleColorTextBox
            // 
            resources.ApplyResources(RectangleColorTextBox, "RectangleColorTextBox");
            RectangleColorTextBox.Name = "RectangleColorTextBox";
            RectangleColorTextBox.TextChanged += RectangleColorTextBox_TextChanged;
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            resources.ApplyResources(RectanglesListBox, "RectanglesListBox");
            RectanglesListBox.Items.AddRange(new object[] { resources.GetString("RectanglesListBox.Items"), resources.GetString("RectanglesListBox.Items1"), resources.GetString("RectanglesListBox.Items2"), resources.GetString("RectanglesListBox.Items3"), resources.GetString("RectanglesListBox.Items4") });
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // RectangleTabPage
            // 
            RectangleTabPage.Controls.Add(panel1);
            resources.ApplyResources(RectangleTabPage, "RectangleTabPage");
            RectangleTabPage.Name = "RectangleTabPage";
            RectangleTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Name = "panel1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainTabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
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
            MoviesGroupBox.ResumeLayout(false);
            MoviesGroupBox.PerformLayout();
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            RectangleTabPage.ResumeLayout(false);
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
        private Button RectangleFindButton;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox RectagleLenghtTextBox;
        private TextBox RectangleWidthTextBox;
        private TextBox RectangleColorTextBox;
        private ListBox RectanglesListBox;
        private GroupBox MoviesGroupBox;
        private Button MovieFindButton;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox MovieDurationTextBox;
        private TextBox MovieReleaseYearTextBox;
        private TextBox MovieRatingTextBox;
        private ListBox MovieListBox;
        private Label label13;
        private TextBox MovieGenreTextBox;
        private Label label12;
        private TextBox MovieTitleTextBox;
        private Label label15;
        private Label label14;
        private TextBox RectangleCenterYTextBox;
        private TextBox RectangleCenterXTextBox;
        private Label label16;
        private TextBox RectangleIdTextBox;
        private TabPage RectangleTabPage;
        private Panel panel1;
    }
}