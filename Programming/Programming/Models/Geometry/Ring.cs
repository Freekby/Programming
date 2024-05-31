namespace Programming
{
    /// <summary>
    /// класс кольца
    /// </summary>
    public class Ring
    {
        private double _externalRadius;
        private double _internalRadius;

        /// <summary>
        /// конструктор класса 
        /// </summary>
        /// <param name="externalRadius"></param>
        /// <param name="internalRadius"></param>
        /// <param name="centerX"></param>
        /// <param name="centerY"></param>
        public Ring(double externalRadius, double internalRadius, double centerX, double centerY)
        {
            ExternalRadius = externalRadius;
            InternalRadius = internalRadius;
            Center = new Point2D(centerX, centerY);
        }

        /// <summary>
        /// пустой конструктор класса
        /// </summary>
        public Ring() { }

        /// <summary>
        /// точка центра кольца
        /// </summary>
        public Point2D Center { get; private set; }

        private double GetRingArea()
        {
            return Math.PI * ExternalRadius * ExternalRadius - Math.PI * InternalRadius * InternalRadius;
        }

        /// <summary>
        /// площадь кольца
        /// </summary>
        public double Area
        {
            get { return GetRingArea(); }
        }

        /// <summary>
        /// внешний радиус
        /// </summary>
        public double ExternalRadius
        {
            get { return _externalRadius; }
            set 
            {
                Validator.AssertOnPositiveValue(value, nameof(ExternalRadius));

                if (value > InternalRadius)
                {
                    throw new ArgumentException("поле ExternalRadius должно быть больше InternalRadius");
                }
                _externalRadius = value; 
            }
        }

        /// <summary>
        /// внутренний радиус
        /// </summary>
        public double InternalRadius
        {
            get { return _internalRadius; }
            set
            {
                Validator.AssertOnPositiveValue(_internalRadius, nameof(InternalRadius));

                if (value < ExternalRadius)
                {
                    throw new ArgumentException("поле InternalRadius должно быть меньше ExternalRadius");
                }
                _internalRadius = value;
            }
        }
    }
}