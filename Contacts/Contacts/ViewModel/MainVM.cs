using Contacts.Model;
using Contacts.Model.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Contacts.ViewModel
{
    /// <summary>
    /// Класс для привязки данных к форме.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Текущий выбранный контакт.
        /// </summary>
        private Contact _currentContact;

        /// <summary>
        /// Показывает включен ли режим редактирования или нет.
        /// </summary>
        private bool _isEditMode = false;

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
            if (!CurrentContact.IsEdited)
            {
                Contacts.Add(CurrentContact);
            }

            CurrentContact.EndEdit();
            IsEditMode = false;
            SaveContacts();

            Contact contactContainer = CurrentContact;
            CurrentContact = null;
            CurrentContact = contactContainer;
        }

        /// <summary>
        /// Функция начала редактирования контакта.
        /// </summary>
        /// <param name="obj"></param>
        private void Edit(object obj)
        {
            CurrentContact.BeginEdit();
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
            CurrentContact.BeginEdit();
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
            CurrentContact?.EndEdit();
            ContactSerializer.SaveContacts(Contacts);
        }

        /// <summary>
        /// Функция отмены добавления контакта.
        /// </summary>
        /// <param name="newContact"></param>
        private void CancelAdding(Contact newContact)
        {
            if (!newContact.IsEdited)
            {
                Contacts.Remove(newContact);
            }
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
                    CurrentContact.CancelEdit();
                    CancelAdding(CurrentContact);
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
                    (_applyCommand = new RelayCommand(Apply));
            }
        }

        /// <summary>
        /// Конструктор класса <see cref="MainVM"/>
        /// </summary>
        public MainVM()
        {
            Contacts = ContactSerializer.LoadContacts();
        }

        /// <summary>
        /// Событие изменения свойства.
        /// </summary>
        /// <param name="propertyName">Имя свойства вызвавшего событие.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
