using System;

namespace Programming.View
{
    public partial class RectangleCollisions : UserControl
    {
        public RectangleCollisions()
        {
            InitializeComponent();
        }

        private static List<Rectangle> _rectangles = new List<Rectangle>();
        private static Rectangle _currentRectangle = null;
        private static List<Panel> _rectanglePanels = new List<Panel>();

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            Rectangle newRectangle = RectangleFactory.Randomize(RectanglesPanel.Size.Height, RectanglesPanel.Size.Width);
            _rectangles.Add(newRectangle);

            RectanglesListBox.Items.Add($"{newRectangle.Id}. (X = {newRectangle.Center.X}, Y = {newRectangle.Center.Y}, W = {newRectangle.Width}; H = {newRectangle.Height})");

            Panel newPanel = new Panel();
            newPanel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            // Находим координаты точки верхнего левого края прямоугольника
            newPanel.Location = new Point((int)(newRectangle.Center.X - newRectangle.Width / 2), (int)(newRectangle.Center.Y - newRectangle.Height / 2));
            newPanel.Width = (int)newRectangle.Width;
            newPanel.Height = (int)newRectangle.Height;

            _rectanglePanels.Add(newPanel);
            RectanglesPanel.Controls.Add(newPanel);
            FindCollisions();
        }

        private void DeleteRectangleButton_Click(object sender, EventArgs e)
        {
            ClearRectangleInfo();
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentRectangleIndex = RectanglesListBox.SelectedIndex;

            if (currentRectangleIndex < 0)
            {
                RectangleIdTextBox.Text = string.Empty;
                RectangleCenterXTextBox.Text = string.Empty;
                RectangleCenterYTextBox.Text = string.Empty;
                RectangleWidthTextBox.Text = string.Empty;
                RectangleHeightTextBox.Text = string.Empty;
            }
            else
            {
                _currentRectangle = _rectangles[currentRectangleIndex];

                RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
                RectangleHeightTextBox.Text = _currentRectangle.Height.ToString();
                RectangleCenterXTextBox.Text = _currentRectangle.Center.X.ToString();
                RectangleCenterYTextBox.Text = _currentRectangle.Center.Y.ToString();
                RectangleIdTextBox.Text = _currentRectangle.Id.ToString();
            }
        }

        private void RectangleCenterXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectangleCenterXTextBox.Text)) return;
            try
            {
                int text = int.Parse(RectangleCenterXTextBox.Text);
                _currentRectangle.Center = new Point2D(text, _currentRectangle.Center.Y);
                RectangleCenterXTextBox.BackColor = System.Drawing.Color.White;
                UpdateRectangleInfo();

                _rectanglePanels[RectanglesListBox.SelectedIndex].Location = new Point(
                    text - _rectanglePanels[RectanglesListBox.SelectedIndex].Width / 2,
                    _rectanglePanels[RectanglesListBox.SelectedIndex].Location.Y);

                FindCollisions();
            }
            catch (Exception)
            {
                RectangleCenterXTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RectanglesCenterYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectangleCenterYTextBox.Text)) return;
            try
            {
                int text = int.Parse(RectangleCenterYTextBox.Text);
                _currentRectangle.Center = new Point2D(_currentRectangle.Center.X, int.Parse(RectangleCenterYTextBox.Text));
                RectangleCenterYTextBox.BackColor = System.Drawing.Color.White;
                UpdateRectangleInfo();

                _rectanglePanels[RectanglesListBox.SelectedIndex].Location = new Point(
                    _rectanglePanels[RectanglesListBox.SelectedIndex].Location.X,
                    text - _rectanglePanels[RectanglesListBox.SelectedIndex].Height / 2);

                FindCollisions();
            }
            catch (Exception)
            {
                RectangleCenterYTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectangleWidthTextBox.Text)) return;
            try
            {
                int text = int.Parse(RectangleWidthTextBox.Text);
                _currentRectangle.Width = text;
                RectangleWidthTextBox.BackColor = System.Drawing.Color.White;
                UpdateRectangleInfo();

                _rectanglePanels[RectanglesListBox.SelectedIndex].Width = text;

                FindCollisions();
            }
            catch (Exception)
            {
                RectangleWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RectangleHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RectangleHeightTextBox.Text)) return;
            try
            {
                int text = int.Parse(RectangleHeightTextBox.Text);
                _currentRectangle.Height = text;
                RectangleHeightTextBox.BackColor = System.Drawing.Color.White;
                UpdateRectangleInfo();

                _rectanglePanels[RectanglesListBox.SelectedIndex].Height = text;

                FindCollisions();
            }
            catch (Exception)
            {
                RectangleHeightTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void UpdateRectangleInfo()
        {
            Rectangle selectedRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = $"{selectedRectangle.Id}. (X = {selectedRectangle.Center.X}, Y = {selectedRectangle.Center.Y}; W = {selectedRectangle.Width}; H = {selectedRectangle.Height})";
        }

        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
                for (int j = 0; j < _rectanglePanels.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]) && i != j)
                    {
                        _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }

        private void ClearRectangleInfo()
        {
            if (RectanglesListBox.SelectedIndex < 0) return;
            _rectangles.RemoveAt(RectanglesListBox.SelectedIndex);
            _rectanglePanels.RemoveAt(RectanglesListBox.SelectedIndex);
            RectanglesPanel.Controls.RemoveAt(RectanglesListBox.SelectedIndex);
            RectanglesListBox.Items.RemoveAt(RectanglesListBox.SelectedIndex);

            FindCollisions();
        }
    }
}
