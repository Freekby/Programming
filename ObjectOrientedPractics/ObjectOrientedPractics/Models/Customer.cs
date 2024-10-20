namespace ObjectOrientedPractices
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Фамилия, имя и отчество покупателя.
        /// </summary>
        private string _fullName;
        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Список заказов покупателя.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Возвращает значение поля id.
        /// </summary>
        public int ID { get { return _id; } }

        /// <summary>
        /// Возвращает и задаёт список заказов покупателя.
        /// </summary>
        public List<Order> Orders 
        { 
            get { return _orders; } 
            set { _orders = value; }
        }

        /// <summary>
        /// Возвращает значение корзины покупателя.
        /// </summary>
        public Cart Cart 
        { 
            get { return _cart; } 
            private set { _cart = value; }
        }

        /// <summary>
        /// Возвращает и задаёт имя, фамилию и отчество покупателя. Не может быть больше 200 символов или пустым.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                ValueValidator.CheckStringOnNullOrEmpty(value, nameof(FullName));
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));

                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес покупателя.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            _id = IdGenerator.GetNextId();
            FullName = "fullName";
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName"> имя, фамилия и отчество покупателя </param>
        /// <param name="address"> адрес покупателя </param>
        public Customer(string fullName, Address address)
        {
            _id = IdGenerator.GetNextId();
            FullName = fullName;
            Address = address;
            Cart = new Cart();
            Orders = new List<Order>();
        }

        /// <summary>
        /// Возвращает имя покупателя.
        /// </summary>
        /// <returns> string </returns>
        public override string ToString()
        {
            return FullName;
        }
    }
}
