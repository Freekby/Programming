namespace Programming
{
    /// <summary>
    /// прямоугольник
    /// </summary>
    public class Rectangle
    {
        private double _height;
        private double _width;
        private int _id;
        private static int _allRectangleCount = 0;

        /// <summary>
        /// пустой конструктор класса
        /// </summary>
        public Rectangle()
        {
            Id = _allRectangleCount++;
        }

        /// <summary>
        /// конструктор класса 
        /// </summary>
        /// <param name="height">длинна</param>
        /// <param name="width">ширина</param>
        /// <param name="color">цвет</param>
        /// <param name="centerX">координата x центра</param>
        /// <param name="centerY">координата y центра</param>
        public Rectangle(double height, double width, string color, double centerX, double centerY)
        {
            Height = height;
            Width = width;
            Color = color;
            Center = new Point2D(centerX, centerY);
            _allRectangleCount++;
            Id = _allRectangleCount;

        }

        /// <summary>
        ///  конструктор класса без цвета
        /// </summary>
        /// <param name="height">длинна</param>
        /// <param name="width">ширина</param>
        /// <param name="centerX">координата x центра</param>
        /// <param name="centerY">координата y центра</param>
        public Rectangle(double height, double width, double centerX, double centerY)
        {
            Height = height;
            Width = width;
            Center = new Point2D(centerX, centerY);
            _allRectangleCount++;
            Id = _allRectangleCount;

        }

        /// <summary>
        /// цвет 
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// точка центра
        /// </summary>
        public Point2D Center { get; set; }


        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        /// <summary>
        /// общее количество прямоугольников 
        /// </summary>
        public static int AllRectanglesCount
        {
            get { return _allRectangleCount; }
            private set { _allRectangleCount = value; }
        }

        /// <summary>
        /// длинна
        /// </summary>
        public double Height
        {
            get { return _height; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Height));
                _height = value;
            }
        }

        /// <summary>
        /// ширина 
        /// </summary>
        public double Width
        {
            get { return _width; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

    }
}
