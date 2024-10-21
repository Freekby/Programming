namespace ObjectOrientedPractices
{
    /// <summary>
    /// Хранит данные о заказе покупателя.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Поле списка товаров.
        /// </summary>
        private List<Item> _items;


        /// <summary>
        /// Возвращает значение поля Items.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
        }

        /// <summary>
        /// Расчитывает и возвращает общую стоимость корзины.
        /// </summary>
        /// <returns> double </returns>
        public double Amount
        {
            get
            {
                double totalCost = 0.0;

                if (_items == null || _items.Count == 0)
                {
                    return totalCost;
                }

                foreach (var item in _items)
                {
                    totalCost += item.Cost;
                }
                return totalCost;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {
            _items = new List<Item>();
        }

        /// <summary>
        /// Добавляет товары в корзину.
        /// </summary>
        /// <param name="item"> добавляемый товар. </param>
        public void AddItem(Item item)
        {
            if (item != null)
            {
                _items.Add(item);
            }
        }

        /// <summary>
        /// Удаляет товары из корзины.
        /// </summary>
        /// <param name="item"> удаляемый товар. </param>
        public void RemoveItem(Item item) 
        {
            if (item != null)
            {
                _items.Remove(item);
            }
        }

        /// <summary>
        /// Очищает корзину.
        /// </summary>
        public void Clear() 
        { 
            _items = new List<Item>();
        }
    }
}
