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
        private readonly MainVM _mainVM;

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

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
