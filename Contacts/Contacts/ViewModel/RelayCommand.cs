using System.Windows.Input;

namespace Contacts.ViewModel
{
    /// <summary>
    /// Класс для создания комманд по шаблону.
    /// </summary>
    class RelayCommand : ICommand
    {
        /// <summary>
        /// Хранит функцию для выполнения.
        /// </summary>
        private readonly Action<object> _execute;

        /// <summary>
        /// Хранит функцию для проверки возможности выполнения.
        /// </summary>
        private readonly Predicate<object>? _canExecute;

        ///<inheritdoc/>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Конструктор класса <see cref="RelayCommand"/>.
        /// </summary>
        /// <param name="execute">Исполняемая функция.</param>
        /// <param name="canExecute">Метод, который определяет, может ли команда быть выполенена.</param>
        public RelayCommand(Action<object> execute, Predicate<object>? canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        ///<inheritdoc/>
        public bool CanExecute(object? parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        ///<inheritdoc/>
        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
