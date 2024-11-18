using ObjectOrientedPractices.Models.Enums;

namespace ObjectOrientedPractices.Models.Orders
{
    /// <summary>
    /// Хранит данные о заказе приоритетного обслуживания
    /// </summary>
    internal class PriorityOrder : Order
    {
        /// <summary>
        /// Доступное время доставки.
        /// </summary>
        private static List<string> _rangesList = new List<string> { "9:00 – 11:00", "11:00 – 13:00", "13:00 – 15:00", "15:00 – 17:00", "17:00 – 19:00", "19:00 – 21:00" };
        /// <summary>
        /// Желаемая дата доставки
        /// </summary>
        private DateTime _deliveryDate;
        /// <summary>
        /// Желаемое время доставки
        /// </summary>
        private string _deliveryTime;

        /// <summary>
        /// Возвращает список с доступным временем доставки
        /// </summary>
        public static List<string> RangesList { get { return new List<string>(_rangesList); } }

        /// <summary>
        /// Возвращает и задаёт дату доставки.
        /// </summary>
        public DateTime DeliveryDate
        {
            get { return _deliveryDate; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentException($"{nameof(DeliveryDate)} должно быть больше либо равно нынешней дате");
                }

                _deliveryDate = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт время доставки.
        /// </summary>
        public string DeliveryTime
        {
            get { return _deliveryTime; }
            set
            {
                if (!_rangesList.Contains(value))
                {
                    throw new ArgumentException($"{nameof(DeliveryTime)} не принадлежит заданным дапазонам");
                }
                _deliveryTime = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder() : base()
        {
            DeliveryDate = DateTime.Now.AddDays(1);
            DeliveryTime = _rangesList[0];
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder(DateTime deliveryDate, string deliveryTime, Address address, List<Item> items, double cost) : base(address, items, cost)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }
    }
}
