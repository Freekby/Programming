namespace ObjectOrientedPractices
{
    /// <summary>
    /// хранит данные о покупателе
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// уникальный идентификатор
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// фамилия, имя и отчество покупателя
        /// </summary>
        private string _fullName;
        /// <summary>
        /// адрес покупателя
        /// </summary>
        private Address _address;

        /// <summary>
        /// возвращает значение поля id
        /// </summary>
        public int ID { get { return _id; } }

        /// <summary>
        /// возвращает и задаёт имя, фамилию и отчество покупателя. Не может быть больше 200 символов или пустым
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
        /// возвращает и задаёт адрес покупателя.
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
        /// создаёт пустой экземпляр класса <see cref="Customer"/>
        /// </summary>
        public Customer()
        {
            _id = IdGenerator.GetNextId();
            FullName = "fullName";
            Address = new Address();
        }

        /// <summary>
        /// создаёт экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullName"> имя, фамилия и отчество покупателя </param>
        /// <param name="address"> адрес покупателя </param>
        public Customer(string fullName, Address address)
        {
            _id = IdGenerator.GetNextId();
            FullName = fullName;
            Address = address;
        }

        /// <summary>
        /// возвращает имя покупателя
        /// </summary>
        /// <returns> string </returns>
        public override string ToString()
        {
            return FullName;
        }
    }
}
