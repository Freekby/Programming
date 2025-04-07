using ContactCollection.Model.Services;
using ContactCollection.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Runtime.CompilerServices;

namespace ContactCollection.ViewModel
{
    /// <summary>
    /// Основной класс ViewModel (MainVM) для управления контактами.
    /// Реализует интерфейс INotifyPropertyChanged для обновления данных в UI.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Текущий выбранный контакт.
        /// </summary>
        private Contact _currentContact;

        private ContactSerializer _serializer = new ContactSerializer();    

        /// <summary>
        /// Показывает включен ли режим редактирования или нет.
        /// </summary>
        private bool _isEditMode = false;

        /// <summary>
        /// Показывает создан ли контакт.
        /// </summary>
        private bool _isNewContact = false;

        /// <summary>
        /// Индекс редактируемого контакта.
        /// </summary>
        private int _editedContactIndex = -1;

        /// <summary>
        /// Команда добавления элемента.
        /// </summary>
        private ICommand _addCommand;

        /// <summary>
        /// Команда удаления элемента.
        /// </summary>
        private ICommand _removeCommand;

        /// <summary>
        /// Команада изменения элемента.
        /// </summary>
        private ICommand _editCommand;

        /// <summary>
        /// Команда применения изменений.
        /// </summary>
        private ICommand _applyCommand;

        /// <summary>
        /// Функция принятия изменений контакта.
        /// </summary>
        /// <param name="obj"></param>
        private void Apply(object obj)
        {
            if (_isNewContact)
            {
                Contacts.Add(CurrentContact);
                _isNewContact = false;
            }
            else
            {
                Contacts[_editedContactIndex] = CurrentContact;
                CurrentContact = Contacts[_editedContactIndex];
                _editedContactIndex = -1;
            }

            IsEditMode = false;
            SaveContacts();

            Contact contactContainer = CurrentContact;
            CurrentContact = null;
            CurrentContact = contactContainer;
        }

        private bool CanApply(object obj)
        {
            return CurrentContact != null &&
                   string.IsNullOrEmpty(CurrentContact[nameof(Contact.Name)]) &&
                   string.IsNullOrEmpty(CurrentContact[nameof(Contact.PhoneNumber)]) &&
                   string.IsNullOrEmpty(CurrentContact[nameof(Contact.Email)]);
        }

        /// <summary>
        /// Функция начала редактирования контакта.
        /// </summary>
        /// <param name="obj"></param>
        private void Edit(object obj)
        {
            var clonnedContact = new Contact()
            {
                Email = CurrentContact.Email,
                PhoneNumber = CurrentContact.PhoneNumber,
                Name = CurrentContact.Name
            };
            _editedContactIndex = Contacts.IndexOf(CurrentContact);
            CurrentContact = clonnedContact;

            _isNewContact = false;
            IsEditMode = true;
        }

        /// <summary>
        /// Проверяет возможность редактирования контакта.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool CanEdit(object obj)
        {
            return Contacts.Contains((Contact)obj);
        }

        /// <summary>
        /// функция добавления контакта в список.
        /// </summary>
        /// <param name="obj"></param>
        private void Add(object obj)
        {
            Contact newContact = new Contact();
            CurrentContact = newContact;
            _isNewContact = true;
            IsEditMode = true;
        }

        /// <summary>
        /// Функция удаления контакта.
        /// </summary>
        /// <param name="obj"></param>
        private void Remove(object obj)
        {
            int oldIndex = Contacts.IndexOf((Contact)obj);
            Contacts.Remove((Contact)obj);
            SaveContacts();

            if (Contacts.Count() > oldIndex)
            {
                CurrentContact = Contacts[oldIndex];
            }
            else if (Contacts.Count() == 0)
            {
                return;
            }
            else
            {
                CurrentContact = Contacts[oldIndex - 1];
            }
        }

        /// <summary>
        /// Проверяет возможность удаления контакта.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>ture если функция может быть выполнена. Иначе false.</returns>
        private bool CanRemove(object obj)
        {
            return Contacts.Contains((Contact)obj);
        }

        /// <summary>
        /// функция сохранения контакта.
        /// </summary>
        private void SaveContacts()
        {
            _serializer.SaveContacts(Contacts);
        }

        /// <inheritdoc/>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact CurrentContact
        {
            get { return _currentContact; }
            set
            {
                if (CurrentContact is not null && CurrentContact != value)
                {
                    IsEditMode = false;
                }

                _currentContact = value;
                OnPropertyChanged(nameof(CurrentContact));
            }
        }

        /// <summary>
        /// определяет включен ли режим редактирвания.
        /// </summary>
        public bool IsEditMode
        {
            get { return _isEditMode; }
            set
            {
                _isEditMode = value;
                OnPropertyChanged(nameof(IsEditMode));
            }
        }

        /// <summary>
        /// Список всех контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; private set; }

        /// <summary>
        /// Команда добавления контакта.
        /// </summary>
        public ICommand AddCommand
        {
            get
            {
                return _addCommand ??
                    (_addCommand = new RelayCommand(Add));
            }
        }

        /// <summary>
        /// Команда удаления контакта.
        /// </summary>
        public ICommand RemoveCommand
        {
            get
            {
                return _removeCommand ??
                    (_removeCommand = new RelayCommand(Remove, CanRemove));
            }
        }

        /// <summary>
        /// Команда редактирования контакта.
        /// </summary>
        public ICommand EditCommand
        {
            get
            {
                return _editCommand ??
                    (_editCommand = new RelayCommand(Edit, CanEdit));
            }
        }

        /// <summary>
        /// Команда принятия изменений контакта.
        /// </summary>
        public ICommand ApplyCommand
        {
            get
            {
                return _applyCommand ??
                    (_applyCommand = new RelayCommand(Apply, CanApply));
            }
        }

        /// <summary>
        /// Конструктор класса <see cref="MainVM"/>
        /// </summary>
        public MainVM()
        {
            ObservableCollection<Contact> loadedContacts = _serializer.LoadContacts();
            Contacts = loadedContacts;
        }

        /// <summary>
        /// Событие изменения свойства.
        /// </summary>
        /// <param name="propertyName">Имя свойства вызвавшего событие.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
