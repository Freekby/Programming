using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Класс для привязки данных к форме.
    /// </summary>
    class MainVM : INotifyPropertyChanged
    {
        private string _name = string.Empty;
        private string _email = string.Empty;
        private string _phoneNumber = string.Empty;
        private Contact _contact = new Contact();
        private ICommand _loadCommand;
        private ICommand _saveCommand;

        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Имя.
        /// </summary>
        public string Name 
        { 
            get { return _name; }
            set 
            {
                _name = value;
                _contact.Name = value;
                OnPropertyChanged(nameof(Name));
            } 
        }

        /// <summary>
        /// Почта.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                _contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Номер телефона.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                _contact.PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        /// <summary>
        /// Экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact Contact 
        { 
            get { return _contact; }
        }

        /// <summary>
        /// Возвращает команду загрузки данных.
        /// </summary>
        public ICommand LoadCommand
        {
            get
            {
                return _loadCommand ??
                    (_loadCommand = new LoadCommand(this));
            }
        }

        /// <summary>
        /// Возвращает команду выгрузки данных.
        /// </summary>
        public ICommand SaveCommand
        {
            get
            {
                return _saveCommand ??
                    (_saveCommand = new SaveCommand());
            }
        }

        /// <summary>
        /// Событие изменения свойства.
        /// </summary>
        /// <param name="propertyName">Имя свойства вызвавшего событие.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
