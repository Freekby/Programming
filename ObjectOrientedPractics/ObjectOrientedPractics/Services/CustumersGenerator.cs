namespace ObjectOrientedPractices
{
    /// <summary>
    /// класс, генерирующий покупателей
    /// </summary>
    internal static class CustumersGenerator
    {
        /// <summary>
        /// счётчик сгенерированных покупателей
        /// </summary>
        private static int _custumersGeneratedCount = 0;
        
        /// <summary>
        /// генерирует экземпляр класса Customer и возвращает его
        /// </summary>
        /// <returns> Customer </returns>
        public static Customer GetNextCustomer()
        {
            Customer newCustomer = new Customer($"full name{_custumersGeneratedCount}", $"address{_custumersGeneratedCount}");
            _custumersGeneratedCount++;
            return newCustomer;
        }
    }
}
