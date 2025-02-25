namespace View.Model
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    class Contact
    {
        private string _name;
        private string _email;
        private string _phoneNumber;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Почта контакта.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        /// <summary>
        /// Конструктор класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="email">Почта.</param>
        /// <param name="phoneNumber">Номер телефона.</param>
        public Contact(string name = "", string email = "", string phoneNumber = "")
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
