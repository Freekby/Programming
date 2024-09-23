namespace ObjectOrientedPractices
{
    /// <summary>
    /// класс, генерирующий товары
    /// </summary>
    internal static class ItemGenerator
    {
        /// <summary>
        /// счётчик сгенерированных товаров
        /// </summary>
        private static int itemGeneratedCount=0;

        /// <summary>
        /// генерирует экземпляр класса Item и возвращает его
        /// </summary>
        /// <returns> Item </returns>
        public static Item Generate()
        {
            Item item = new Item($"name{itemGeneratedCount}", $"info{itemGeneratedCount}", itemGeneratedCount);
            itemGeneratedCount++;
            return item;
        }
    }
}
