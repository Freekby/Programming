namespace ObjectOrientedPractices
{
    /// <summary>
    /// Хранит данные о заказе покупателя.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private readonly DateTime _date;

        /// <summary>
        /// Адрес доставки заказа.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Товары в заказе.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Стоимость заказа.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Статус заказа.
        /// </summary>
        private OrderStatus _status;

        /// <summary>
        /// Возвращает и задаёт статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// Возвращает уникальный идентификатор.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime Date { get { return _date; } }

        /// <summary>
        /// Возвращает и задаёт адрес доставки заказа.
        /// </summary>
        public Address Address 
        { 
            get { return _address; } 
            set { _address = value; }
        }

        /// <summary>
        /// Возвращает и задаёт список товаров в заказе.
        /// </summary>
        public List<Item> Items 
        {  
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает и задаёт цену заказа.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="items"></param>
        /// <param name="cost"></param>
        public Order(Address address, List<Item> items, double cost)
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            Address = address;
            Items = items;
            Cost = cost;
            Status = OrderStatus.New;
        }
    }
}
