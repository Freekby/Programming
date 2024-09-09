namespace ObjectOrientedPractices
{
    /// <summary>
    /// хранит данные о покупателе
    /// </summary>
    internal class Customer
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
        private string _address;

        /// <summary>
        /// возвращает и задаёт имя, фамилию и отчество покупателя. Не может быть больше 200 символов или пустым
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                ValueValidator.CheckStringOnNullOrEmpty(value, FullName);
                ValueValidator.AssertStringOnLength(value, 200, FullName);

                _fullName = value;
            }
        }

        /// <summary>
        /// возвращает и задаёт адрес покупателя. не может быть больше 500 символов или пустым 
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                ValueValidator.CheckStringOnNullOrEmpty(_address, Address);
                ValueValidator.AssertStringOnLength(_address, 500, Address);

                _address = value;
            }
        }

        ///// <summary>
        ///// создаёт экземпляр класса <see cref="Customer"/>
        ///// </summary>
        //public Customer()
        //{

        //}

        /// <summary>
        /// создаёт экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullName"> имя, фамилия и отчество покупателя </param>
        /// <param name="address"> адрес покупателя </param>
        public Customer(string fullName, string address)
        {
            _id = IdGenerator.GetNextId();
            FullName = fullName;
            Address = address;
        }
    }
}
