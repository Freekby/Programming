using System.Windows.Input;
using View.Model.Services;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Класс для команд загрузки информации о клиенте.
    /// </summary>
    internal class LoadCommand : ICommand
    {
        /// <summary>
        /// Экземпляр класса <see cref="MainVM"/>.
        /// Нужен для изменения данных контакта.
        /// </summary>
        private readonly MainVM _mainVM;

        /// <inheritdoc/>
        public event EventHandler? CanExecuteChanged;

        /// <inheritdoc/>
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        /// <inheritdoc/>
        public void Execute(object? parameter)
        {
            Contact savedContact = ContactSerializer.DeSerialise();

            _mainVM.Name = savedContact.Name;
            _mainVM.PhoneNumber = savedContact.PhoneNumber;
            _mainVM.Email = savedContact.Email;
        }

        /// <summary>
        /// Конструктор класса <see cref="LoadCommand"/>.
        /// </summary>
        /// <param name="mainVM">Экземпляр класса <see cref="MainVM"/></param>
        public LoadCommand(MainVM mainVM)
        {
            _mainVM = mainVM;
        }
    }
}
