using ObjectOrientedPractices.Models.Enums;

namespace ObjectOrientedPractices
{
    /// <summary>
    /// класс, генерирующий товары
    /// </summary>
    internal static class ItemGenerator
    {
        /// <summary>
        /// генерирует экземпляр класса Item и возвращает его
        /// </summary>
        /// <returns> Item </returns>
        public static Item GetNextItem()
        {
            Item item = new Item();
            return item;
        }
    }
}
