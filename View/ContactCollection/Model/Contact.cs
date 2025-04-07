using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ContactCollection.Model
{
    /// <summary>
    /// Класс, представляющий контактную информацию.
    /// Реализует интерфейс INotifyPropertyChanged для уведомления об изменении свойств.
    /// </summary>
    public class Contact : INotifyPropertyChanged, IDataErrorInfo
    {
        /// <summary>
        /// Хранит данные контакта до изменения.
        /// </summary>
        private Contact _lastContact;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Номер теефлна.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Электронная почта.
        /// </summary>
        private string _email;

        [StringLength(100)]
        /// <summary>
        /// Имя контакта.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        [StringLength(100)]
        [RegularExpression(@"^\+[0-9]\s?\(?\d{3}\)?\s?\d{3}[-\s]?\d{2}[-\s]?\d{2}$")]
        /// <summary>
        /// Почта контакта.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        [StringLength(100)]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

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
                        if (string.IsNullOrEmpty(Name))
                            error = "Имя не может быть пустым.";
                        else if (Name?.Length > 100)
                            error = "Имя не должно превышать 100 символов.";

                        break;
                    case nameof(PhoneNumber):
                        if (string.IsNullOrEmpty(PhoneNumber))
                            error = "Номер телефона не может быть пустым.";
                        else if (PhoneNumber?.Length > 100)
                            error = "Номер телефона не должен превышать 100 символов.";
                        else if (!System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber, @"^\+[0-9]\s?\(?\d{3}\)?\s?\d{3}[-\s]?\d{2}[-\s]?\d{2}$"))
                            error = "Номер телефона должен содержать только цифры или символы +-().";

                        break;
                    case nameof(Email):
                        if (string.IsNullOrEmpty(Email))
                            error = "Адрес почты не может быть пустым.";
                        else if (Email?.Length > 100)
                            error = "Адрес почты не должен превышать 100 символов.";
                        else if (!System.Text.RegularExpressions.Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                            error = "Неправильный формат адреса почты.";

                        break;
                }

                return error;
            }
        }

        ///<inheritdoc/>
        public event PropertyChangedEventHandler? PropertyChanged;

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

        /// <summary>
        /// Событие изменения свойства.
        /// </summary>
        /// <param name="propertyName">Имя свойства вызвавшего событие.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
