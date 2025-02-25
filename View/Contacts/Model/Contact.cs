namespace View.Model
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    class Contact
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Почта контакта.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        public string Email { get; set; }

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
