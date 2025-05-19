using CommunityToolkit.Mvvm.ComponentModel; 
using CommunityToolkit.Mvvm.Input;
using Model;
using Model.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ViewModel
{
    /// <summary>
    /// Основной класс ViewModel (MainVM) для управления контактами.
    /// Реализует интерфейс INotifyPropertyChanged для обновления данных в UI.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Текущий выбранный контакт.
        /// </summary>
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(ApplyCommand))]
        [NotifyCanExecuteChangedFor(nameof(EditCommand))]
        [NotifyCanExecuteChangedFor(nameof(RemoveCommand))]
        private Contact _currentContact;

        /// <summary>
        /// Показывает включен ли режим редактирования или нет.
        /// </summary>
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(ApplyCommand))]
        [NotifyCanExecuteChangedFor(nameof(EditCommand))]
        [NotifyCanExecuteChangedFor(nameof(RemoveCommand))]
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
        /// Список всех контактов.
        /// </summary>
        [ObservableProperty]
        public ObservableCollection<Contact> _contacts;

        /// <summary>
        /// Функция принятия изменений контакта.
        /// </summary>
        /// <param name="obj"></param>
        [RelayCommand(CanExecute = nameof(CanApply))]
        private void Apply(object obj)
        {
            CurrentContact.PropertyChanged -= CurrentContanctChanged;
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

        /// <summary>
        /// Проверяет возможность сохранения данных о контакте.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
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
        [RelayCommand(CanExecute = nameof(CanEdit))]
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

            CurrentContact.PropertyChanged += CurrentContanctChanged;
            _isNewContact = false;
            IsEditMode = true;
        }

        /// <summary>
        /// Проверяет возможность редактирования контакта.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true если возможно. Иначе false</returns>
        private bool CanEdit(object obj)
        {
            return Contacts.Contains((Contact)obj);
        }

        /// <summary>
        /// функция добавления контакта в список.
        /// </summary>
        /// <param name="obj"></param>
        [RelayCommand]
        private void Add(object obj)
        {
            Contact newContact = new Contact();
            CurrentContact = newContact;
            _isNewContact = true;
            IsEditMode = true;
            CurrentContact.PropertyChanged += CurrentContanctChanged;
        }

        /// <summary>
        /// Функция удаления контакта.
        /// </summary>
        /// <param name="obj"></param>
        [RelayCommand(CanExecute = nameof(CanRemove))]
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
            ContactSerializer.SaveContacts(Contacts);
        }

        private void CurrentContanctChanged(object? sender, PropertyChangedEventArgs e)
        {
            ApplyCommand.NotifyCanExecuteChanged();
        }

        /// <summary>
        /// Конструктор класса <see cref="MainVM"/>
        /// </summary>
        public MainVM()
        {
            ObservableCollection<Contact> loadedContacts = ContactSerializer.LoadContacts();
            Contacts = loadedContacts;
        }

        partial void OnCurrentContactChanging(Contact oldValue, Contact newValue)
        {
            if (oldValue != null)
            {
                oldValue.PropertyChanged -= CurrentContanctChanged;
            }

            IsEditMode = false;
        }

        partial void OnCurrentContactChanged(Contact value)
        {
            EditCommand.NotifyCanExecuteChanged();
            RemoveCommand.NotifyCanExecuteChanged();
            ApplyCommand.NotifyCanExecuteChanged();
        }
    }
}