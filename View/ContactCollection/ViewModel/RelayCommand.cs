using System.Windows.Input;

namespace ContactCollection.ViewModel
{
    /// <summary>
    /// Реализация интерфейса <see cref="ICommand"/>, 
    /// позволяющая связать действия UI с методами в ViewModel.
    /// </summary>
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// Делегат, представляющий метод для выполнения.
        /// </summary>
        private readonly Action<object> _execute;

        /// <summary>
        /// Делегат, представляющий метод для проверки 
        /// возможности выполнения команды.
        /// </summary>
        private readonly Predicate<object> _canExecute;

        /// <summary>
        /// Конструктор класса RelayCommand.
        /// </summary>
        /// <param name="execute">Выполняемый метод.</param>
        /// <param name="canExecute">Метод проверяющий возможность выполнения.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
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

        /// <summary>
        /// Событие, возникающее при изменении
        /// возможности выполнения команды.
        /// </summary>
        private event EventHandler _canExecuteChanged;

        /// <summary>
        /// событие изменения CanExecute.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add
            {
                _canExecuteChanged += value; 
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                _canExecuteChanged -= value; 
                CommandManager.RequerySuggested -= value;
            }
        }

        /// <summary>
        /// Вызывает событие изменения CanExecute.
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }
    }
}