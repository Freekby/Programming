using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Contacts.Model
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    public class Contact: INotifyPropertyChanged, IEditableObject
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
        
        /// <summary>
        /// Определяет редактировался ли контакт.
        /// </summary>
        public bool IsEdited { get; set; }

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
            IsEdited = false;
        }

        ///<inheritdoc/>
        public void BeginEdit()
        {
            _lastContact = new Contact(Name, Email, PhoneNumber);
        }

        ///<inheritdoc/>
        public void CancelEdit()
        {
            if (_lastContact == null) return;

            Name = _lastContact.Name;
            PhoneNumber = _lastContact.PhoneNumber;
            Email = _lastContact.Email;
        }

        ///<inheritdoc/>
        public void EndEdit()
        {
            _lastContact = null;
            IsEdited = true;
        }

        /// <summary>
        /// Событие изменения свойства.
        /// </summary>
        /// <param name="propertyName">Имя свойства вызвавшего событие.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
