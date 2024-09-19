namespace ObjectOrientedPractices
{
    /// <summary>
    /// класс для проверки значений на правильность ввода
    /// </summary>
    internal static class ValueValidator
    {
        /// <summary>
        /// проверка длинны строки на выход за обозначенные пределы
        /// </summary>
        /// <param name="str">строка</param>
        /// <param name="maxLength">максимальная длинна строки</param>
        /// <param name="propertyName">название свойства, которое вызвало метод</param>
        public static void AssertStringOnLength(string str, int maxLength, string propertyName)
        {
            if (str.Length > maxLength) 
            {
                throw new ArgumentException($"свойство {propertyName} должно быть меньше {maxLength} символов");
            }

        }

        /// <summary>
        /// проверка строки на отсутствие символов или null
        /// </summary>
        /// <param name="str">строка</param>
        /// <param name="propertyName">название свойства, которое вызвало метод</param>
        public static void CheckStringOnNullOrEmpty(string str, string propertyName)
        {
            if (String.IsNullOrEmpty(str)) 
            {
                throw new ArgumentNullException($"свойство {propertyName} не должно быть null или пустым");
            }
        }
    }
}
