namespace Programming
{
    public class Rectangle
    {
        private double length;
        private double width;
        public string Color { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }

        public double Length
        {
            get { return length; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Длина прямоугольника не может быть отрицательной.");
                }
                length = value;
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ширина прямоугольника не может быть отрицательной.");
                }
                width = value;
            }
        }
    }
}
