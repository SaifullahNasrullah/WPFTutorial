using System;
using System.Windows.Input;

namespace WPFTutorial12.MVVM
{
    internal class RelayCommand : ICommand
    {
        private Action<Object> execute; // Function call
        private Func<Object, bool> canExecute;

        public event EventHandler? CanExecuteChanged 
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
            // Allows us to manage the memory 
        }

        public RelayCommand(Action<Object> execute, Func<Object, Boolean> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public Boolean CanExecute(Object? parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(Object? parameter)
        {
            execute(parameter);
        }
    }
}
