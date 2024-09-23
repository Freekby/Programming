namespace ObjectOrientedPractices
{
    /// <summary>
    /// класс для генерации id
    /// </summary>
    internal static class IdGenerator
    {
        /// <summary>
        /// уникальный идентификатор
        /// </summary>
        private static int _id;

        /// <summary>
        /// генерирует уникальный id и возвращает его
        /// </summary>
        /// <returns>int</returns>
        public static int GetNextId() 
        {
            return _id++; 
        }
    }
}
