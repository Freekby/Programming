namespace Programming
{
    public class Rectangle
    {
        private double _height;
        private double _width;
        private int _id;
        private static int _allRectangleCount = 0;

        public Rectangle()
        {
        }

        public Rectangle(double length, double width, string color, double centerX, double centerY)
        {
            Height = length;
            Width = width;
            Color = color;
            Center = new Point2D(centerX, centerY);
            _allRectangleCount++;
            Id = _allRectangleCount;
        }

        public string Color { get; set; }
        public Point2D Center { get; private set; }

        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public static int AllRectangleCount
        {
            get { return _allRectangleCount; }
        }

        public double Height
        {
            get { return _height; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Height));
                _height = value;
            }
        }

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
