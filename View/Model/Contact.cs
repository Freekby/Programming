using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace Model
{

    /// <summary>
    /// Класс, представляющий контактную информацию.
    /// Реализует интерфейс INotifyPropertyChanged для уведомления об изменении свойств.
    /// </summary>
    public partial class Contact : ObservableObject, IDataErrorInfo
    {
        /// <summary>
        /// Хранит данные контакта до изменения.
        /// </summary>
        [ObservableProperty]
        private Contact _lastContact;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        [ObservableProperty]
        private string _name;

        /// <summary>
        /// Номер теефлна.
        /// </summary>
        [ObservableProperty]
        private string _phoneNumber;

        /// <summary>
        /// Электронная почта.
        /// </summary>
        [ObservableProperty]
        private string _email;

        ///<inheritdoc/>
        public string Error
        {
            get { return null; }
        }

        ///<inheritdoc/>
        public string this[string propertyName]
        {
            get
            {
                string error = null;

                switch (propertyName)
                {
                    case nameof(Name):
                        {
                            if (string.IsNullOrEmpty(Name))
                            {
                                error = "Имя не может быть пустым.";
                            }
                            else if (Name?.Length > 100)
                            {
                                error = "Имя не должно превышать 100 символов.";
                            }

                            break;
                        }

                    case nameof(PhoneNumber):
                        {
                            if (string.IsNullOrEmpty(PhoneNumber))
                            {
                                error = "Номер телефона не может быть пустым.";
                            }
                            else if (PhoneNumber?.Length > 100)
                            {
                                error = "Номер телефона не должен превышать 100 символов.";
                            }
                            else if (!System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber, @"^\+[0-9]\s?\(?\d{3}\)?\s?\d{3}[-\s]?\d{2}[-\s]?\d{2}$"))
                            {
                                error = "Номер телефона должен содержать только цифры или символы +-().";
                            }

                            break;
                        }

                    case nameof(Email):
                        {
                            if (string.IsNullOrEmpty(Email))
                            {
                                error = "Адрес почты не может быть пустым.";
                            }
                            else if (Email?.Length > 100)
                            {
                                error = "Адрес почты не должен превышать 100 символов.";
                            }
                            else if (!System.Text.RegularExpressions.Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                            {
                                error = "Неправильный формат адреса почты.";
                            }

                            break;
                        }
                }

                return error;
            }
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