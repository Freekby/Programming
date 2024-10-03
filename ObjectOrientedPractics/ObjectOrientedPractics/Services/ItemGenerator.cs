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
        private static int _itemGeneratedCount=0;

        /// <summary>
        /// генерирует экземпляр класса Item и возвращает его
        /// </summary>
        /// <returns> Item </returns>
        public static Item Generate()
        {
            Item item = new Item($"name{_itemGeneratedCount}", $"info{_itemGeneratedCount}", _itemGeneratedCount, Category.Category1);
            _itemGeneratedCount++;
            return item;
        }
    }
}
