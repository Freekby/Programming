using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Класс для команд выгрузки информации о клиенте.
    /// </summary>
    internal class SaveCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            Contact contact = (Contact)parameter;

            if (contact is null)
            {
                return;
            }

            ContactSerializer.Serialize(contact);
        }
    }
}
