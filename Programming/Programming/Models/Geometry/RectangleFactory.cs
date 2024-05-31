namespace Programming
{
    /// <summary>
    /// класс для генерации прямоугольников
    /// </summary>
    public class RectangleFactory
    {
        /// <summary>
        /// создаёт слуйсайно сгенерированый прямоугольник в границах контейнера
        /// </summary>
        /// <param name="regionHeight">высота контейнера</param>
        /// <param name="regionWidth">ширина контейнера</param>
        /// <returns>Rectangle</returns>
        public static Rectangle Randomize(int regionHeight, int regionWidth)
        {
            Random random = new Random();

            double rectangleHeight = random.Next(30, 100);
            double rectangleWidth = random.Next(30, 100);
            double CenterX = random.Next(50, regionWidth - 50);
            double CenterY = random.Next(50, regionHeight - 50);
            Rectangle myRectangle = new Rectangle(rectangleHeight, rectangleWidth, CenterX, CenterY);

            return myRectangle;
        }
    }
}
