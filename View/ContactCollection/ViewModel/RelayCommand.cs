using System.Windows.Input;

namespace ContactCollection.ViewModel
{
    public class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private Predicate<object> _canExecute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }

        private event EventHandler _canExecuteChanged;

        public event EventHandler CanExecuteChanged
        {
            add
            {
                _canExecuteChanged += value; CommandManager.RequerySuggested += value;
            }
            remove
            {
                _canExecuteChanged -= value; CommandManager.RequerySuggested -= value;
            }
        }

        public void RaiseCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }
    }
}