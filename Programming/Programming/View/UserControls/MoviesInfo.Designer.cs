namespace Programming.View
{
    partial class MoviesInfo
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
            MoviesGroupBox.SuspendLayout();
            SuspendLayout();
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
            MoviesGroupBox.Dock = DockStyle.Fill;
            MoviesGroupBox.Location = new Point(0, 0);
            MoviesGroupBox.Name = "MoviesGroupBox";
            MoviesGroupBox.Size = new Size(308, 273);
            MoviesGroupBox.TabIndex = 2;
            MoviesGroupBox.TabStop = false;
            MoviesGroupBox.Text = "Movies";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ImeMode = ImeMode.NoControl;
            label13.Location = new Point(202, 196);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 18;
            label13.Text = "Genre";
            // 
            // MovieGenreTextBox
            // 
            MovieGenreTextBox.Location = new Point(202, 214);
            MovieGenreTextBox.Name = "MovieGenreTextBox";
            MovieGenreTextBox.Size = new Size(100, 23);
            MovieGenreTextBox.TabIndex = 17;
            MovieGenreTextBox.TextChanged += MovieGenreTextBox_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ImeMode = ImeMode.NoControl;
            label12.Location = new Point(202, 151);
            label12.Name = "label12";
            label12.Size = new Size(30, 15);
            label12.TabIndex = 16;
            label12.Text = "Title";
            // 
            // MovieTitleTextBox
            // 
            MovieTitleTextBox.Location = new Point(202, 169);
            MovieTitleTextBox.Name = "MovieTitleTextBox";
            MovieTitleTextBox.Size = new Size(100, 23);
            MovieTitleTextBox.TabIndex = 15;
            MovieTitleTextBox.TextChanged += MovieTitleTextBox_TextChanged;
            // 
            // MovieFindButton
            // 
            MovieFindButton.ImeMode = ImeMode.NoControl;
            MovieFindButton.Location = new Point(202, 243);
            MovieFindButton.Name = "MovieFindButton";
            MovieFindButton.Size = new Size(100, 23);
            MovieFindButton.TabIndex = 14;
            MovieFindButton.Text = "Find";
            MovieFindButton.UseVisualStyleBackColor = true;
            MovieFindButton.Click += MovieFindButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(202, 107);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 13;
            label9.Text = "Rating";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ImeMode = ImeMode.NoControl;
            label10.Location = new Point(202, 63);
            label10.Name = "label10";
            label10.Size = new Size(71, 15);
            label10.TabIndex = 12;
            label10.Text = "Release year";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ImeMode = ImeMode.NoControl;
            label11.Location = new Point(202, 22);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 11;
            label11.Text = "Duration";
            // 
            // MovieDurationTextBox
            // 
            MovieDurationTextBox.Location = new Point(202, 40);
            MovieDurationTextBox.Name = "MovieDurationTextBox";
            MovieDurationTextBox.Size = new Size(100, 23);
            MovieDurationTextBox.TabIndex = 10;
            MovieDurationTextBox.TextChanged += MovieDurationTextBox_TextChanged;
            // 
            // MovieReleaseYearTextBox
            // 
            MovieReleaseYearTextBox.Location = new Point(202, 81);
            MovieReleaseYearTextBox.Name = "MovieReleaseYearTextBox";
            MovieReleaseYearTextBox.Size = new Size(100, 23);
            MovieReleaseYearTextBox.TabIndex = 9;
            MovieReleaseYearTextBox.TextChanged += MovieReleaseYearTextBox_TextChanged;
            // 
            // MovieRatingTextBox
            // 
            MovieRatingTextBox.Location = new Point(202, 125);
            MovieRatingTextBox.Name = "MovieRatingTextBox";
            MovieRatingTextBox.Size = new Size(100, 23);
            MovieRatingTextBox.TabIndex = 8;
            MovieRatingTextBox.TextChanged += MovieRatingTextBox_TextChanged;
            // 
            // MovieListBox
            // 
            MovieListBox.FormattingEnabled = true;
            MovieListBox.ItemHeight = 15;
            MovieListBox.Items.AddRange(new object[] { "Movie1", "Movie2", "Movie3", "Movie4", "Movie5" });
            MovieListBox.Location = new Point(6, 22);
            MovieListBox.Name = "MovieListBox";
            MovieListBox.Size = new Size(190, 244);
            MovieListBox.TabIndex = 1;
            MovieListBox.SelectedIndexChanged += MovieListBox_SelectedIndexChanged;
            // 
            // MoviesInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MoviesGroupBox);
            MinimumSize = new Size(308, 273);
            Name = "MoviesInfo";
            Size = new Size(308, 273);
            Load += MoviesInfo_Load;
            MoviesGroupBox.ResumeLayout(false);
            MoviesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox MoviesGroupBox;
        private Label label13;
        private TextBox MovieGenreTextBox;
        private Label label12;
        private TextBox MovieTitleTextBox;
        private Button MovieFindButton;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox MovieDurationTextBox;
        private TextBox MovieReleaseYearTextBox;
        private TextBox MovieRatingTextBox;
        private ListBox MovieListBox;
    }
}
