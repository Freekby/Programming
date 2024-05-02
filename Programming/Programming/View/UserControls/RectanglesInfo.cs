namespace Programming.View
{
    public partial class RectanglesInfo : UserControl
    {
        public RectanglesInfo()
        {
            InitializeComponent();
        }

        private void RectanglesInfo_Load(object sender, EventArgs e)
        {
            InitializeRectangles();
            RectanglesListBox.SelectedIndex = 0;
        }

        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle;

        /// <summary>
        /// инициализирует массив _rectangles объектами 
        /// </summary>
        private void InitializeRectangles()
        {
            Random random = new Random();
            for (int i = 0; i < _rectangles.Length; i++)
            {
                double lenght = random.Next(0, 10000) / 100d;
                double width = random.Next(0, 10000) / 100d;
                double CenterX = random.Next(0, 100000) / 100d;
                double CenterY = random.Next(0, 100000) / 100d;
                int RandomColorId = random.Next(0, Enum.GetValues(typeof(Color)).Length);
                string color = Enum.GetValues(typeof(Color)).GetValue(RandomColorId).ToString();

                _rectangles[i] = new Rectangle(lenght, width, color, CenterX, CenterY);
            }
        }

        /// <summary>
        /// при измененинии выбранного прямоугольника отображает его характеристики
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            RectagleLenghtTextBox.Text = _currentRectangle.Height.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleColorTextBox.Text = _currentRectangle.Color;
            RectangleCenterXTextBox.Text = _currentRectangle.Center.X.ToString();
            RectangleCenterYTextBox.Text = _currentRectangle.Center.Y.ToString();
            RectangleIdTextBox.Text = _currentRectangle.Id.ToString();
        }

        /// <summary>
        /// при изменении текста в RectangleLenghtTextBox меняет значение Lenght в выбранном прямоугольнике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleLenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double lenght = double.Parse(RectagleLenghtTextBox.Text);
                _currentRectangle.Height = lenght;
                RectagleLenghtTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                RectagleLenghtTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// при изменении текста в RectangleWidthTextBox меняет значение Width в выбранном прямоугольнике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double Width = double.Parse(RectangleWidthTextBox.Text);
                _currentRectangle.Width = Width;
                RectangleWidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                RectangleWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// при изменении текста в RectangleColorTextBox меняет значение Color в выбранном прямоугольнике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = RectangleColorTextBox.Text;
        }

        /// <summary>
        /// Находит прямоугольник с максимальным параметром Width 
        /// </summary>
        /// <param name="rectangles">массив прямоугольников</param>
        /// <returns>int</returns>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int rectangleWithMaxWidthIndex = 0;
            for (int rect = 0; rect < rectangles.Length; rect++)
            {
                if (rectangles[rect].Width > rectangles[rectangleWithMaxWidthIndex].Width)
                {
                    rectangleWithMaxWidthIndex = rect;
                }
            }
            return rectangleWithMaxWidthIndex;
        }

        /// <summary>
        /// Выбирает в качестве активного элемента в RectanglesListBox элемент с максимальным Width
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

    }
}
