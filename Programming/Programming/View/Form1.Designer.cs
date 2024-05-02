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
            enumerations = new View.Enumerations();
            seasonHandler = new View.SeasonHandler();
            weekdayParsing = new View.WeekdayParsing();
            ClassesPage = new TabPage();
            ClassesGroup = new GroupBox();
            moviesInfo1 = new View.MoviesInfo();
            rectanglesInfo1 = new View.RectanglesInfo();
            RectangleTabPage = new TabPage();
            rectangleCollisions1 = new View.RectangleCollisions();
            MainTabControl.SuspendLayout();
            EnumsPage.SuspendLayout();
            EnumerationsGroup.SuspendLayout();
            ClassesPage.SuspendLayout();
            ClassesGroup.SuspendLayout();
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
            EnumerationsGroup.Controls.Add(enumerations);
            EnumerationsGroup.Controls.Add(seasonHandler);
            EnumerationsGroup.Controls.Add(weekdayParsing);
            resources.ApplyResources(EnumerationsGroup, "EnumerationsGroup");
            EnumerationsGroup.Name = "EnumerationsGroup";
            EnumerationsGroup.TabStop = false;
            // 
            // enumerations
            // 
            resources.ApplyResources(enumerations, "enumerations");
            enumerations.Name = "enumerations";
            // 
            // seasonHandler
            // 
            resources.ApplyResources(seasonHandler, "seasonHandler");
            seasonHandler.Name = "seasonHandler";
            // 
            // weekdayParsing
            // 
            resources.ApplyResources(weekdayParsing, "weekdayParsing");
            weekdayParsing.Name = "weekdayParsing";
            // 
            // ClassesPage
            // 
            ClassesPage.Controls.Add(ClassesGroup);
            resources.ApplyResources(ClassesPage, "ClassesPage");
            ClassesPage.Name = "ClassesPage";
            ClassesPage.UseVisualStyleBackColor = true;
            // 
            // ClassesGroup
            // 
            ClassesGroup.Controls.Add(moviesInfo1);
            ClassesGroup.Controls.Add(rectanglesInfo1);
            resources.ApplyResources(ClassesGroup, "ClassesGroup");
            ClassesGroup.Name = "ClassesGroup";
            ClassesGroup.TabStop = false;
            // 
            // moviesInfo1
            // 
            resources.ApplyResources(moviesInfo1, "moviesInfo1");
            moviesInfo1.Name = "moviesInfo1";
            // 
            // rectanglesInfo1
            // 
            resources.ApplyResources(rectanglesInfo1, "rectanglesInfo1");
            rectanglesInfo1.Name = "rectanglesInfo1";
            // 
            // RectangleTabPage
            // 
            RectangleTabPage.Controls.Add(rectangleCollisions1);
            resources.ApplyResources(RectangleTabPage, "RectangleTabPage");
            RectangleTabPage.Name = "RectangleTabPage";
            RectangleTabPage.UseVisualStyleBackColor = true;
            // 
            // rectangleCollisions1
            // 
            resources.ApplyResources(rectangleCollisions1, "rectangleCollisions1");
            rectangleCollisions1.Name = "rectangleCollisions1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainTabControl);
            Name = "MainForm";
            SizeChanged += MainForm_SizeChanged;
            MainTabControl.ResumeLayout(false);
            EnumsPage.ResumeLayout(false);
            EnumerationsGroup.ResumeLayout(false);
            EnumerationsGroup.PerformLayout();
            ClassesPage.ResumeLayout(false);
            ClassesGroup.ResumeLayout(false);
            RectangleTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage EnumsPage;
        private TabPage tabPage2;
        private GroupBox EnumerationsGroup;
        private TabPage ClassesPage;
        private GroupBox ClassesGroup;
        private TabPage RectangleTabPage;
        private View.WeekdayParsing weekdayParsing;
        private View.SeasonHandler seasonHandler;
        private View.Enumerations enumerations;
        private View.RectanglesInfo rectanglesInfo1;
        private View.MoviesInfo moviesInfo1;
        private View.RectangleCollisions rectangleCollisions1;
    }
}