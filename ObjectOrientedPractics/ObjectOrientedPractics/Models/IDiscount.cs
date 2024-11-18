using ObjectOrientedPractices.Models.Enums;

namespace ObjectOrientedPractices.Models
{
    /// <summary>
    /// Интерфейс скидок.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Возвращает название скидки.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Вычисляет размер скидки.
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>Возвращает размер скидки</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку.
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>Возвращает размер скидки</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Вычисляет процент/баллы скидки.
        /// </summary>
        /// <param name="items">Список товаров</param>
        void Update(List<Item> items);
    }
}
