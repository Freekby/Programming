using ObjectOrientedPractices.Models.Enums;

namespace ObjectOrientedPractices.Models.Orders
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
        /// Задаёт и возвраает сумму скидки.
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// возвращает и задаёт конечную стоимость заказа.
        /// </summary>
        public double Total 
        {
            get
            {
                return Cost - DiscountAmount;
            }
        }

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
        /// Возвращает цену заказа.
        /// </summary>
        public double Cost
        {
            get
            {
                _cost = 0;
                foreach (Item item in _items)
                {
                    _cost += item.Cost;
                }
                return _cost;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            Address = new Address();
            Items = new List<Item>();
            Status = OrderStatus.New;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="items"></param>
        /// <param name="cost"></param>
        public Order(Address address, List<Item> items, double discountAmount)
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            Address = address;
            Items = items;
            DiscountAmount = discountAmount;
            Status = OrderStatus.New;
        }
    }
}
