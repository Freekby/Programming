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
        private string _name;
        private string _email;
        private string _phoneNumber;
        private Contact _contact = new Contact();

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
                OnPropertyChanged("Name");
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
                OnPropertyChanged("Email");
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
                OnPropertyChanged("PhoneNumber");
            }
        }

        /// <summary>
        /// Экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact Contact 
        { 
            get { return _contact; }
        }

        private ICommand _loadCommand;
        public ICommand LoadCommand
        {
            get
            {
                return _loadCommand ??
                    (_loadCommand = new LoadCommand(this));
            }
        }

        private ICommand _saveCommand;
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
