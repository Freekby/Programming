namespace Programming
{
    /// <summary>
    /// точка в двумерном пространстве
    /// </summary>
    public class Point2D
    {
        private double _x;
        private double _y;

        /// <summary>
        /// конструктор класса
        /// </summary>
        /// <param name="x">координата x</param>
        /// <param name="y">координата y</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// координата x
        /// </summary>
        public double X
        {
            get { return _x; }
            private set { _x = value; }
        }

        /// <summary>
        /// координата y
        /// </summary>
        public double Y
        {
            get { return _y; }
            private set { _y = value; }
        }

        /// <summary>
        /// оператор сложения точек 
        /// </summary>
        /// <param name="point1">первая точка</param>
        /// <param name="point2">вторая точка</param>
        /// <returns></returns>
        public static Point2D operator +(Point2D point1, Point2D point2)
        {
            return new Point2D(point1.X + point2.X, point1.Y + point2.Y);
        }
    }
}

