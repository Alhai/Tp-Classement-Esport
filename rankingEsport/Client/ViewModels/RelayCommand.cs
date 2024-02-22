using System.Diagnostics.Metrics;
using System.Windows.Input;

namespace rankingEsport.ViewModels
{
    internal class RelayCommand : ICommand
    {
        private Action<object> addPlayer;

        public RelayCommand(Action<object> addPlayer)
        {
            this.addPlayer = addPlayer;
        }

        public ICommand AddPlayer { get; set; }

        public event EventHandler? CanExecuteChanged
        {
            add
            {
                AddPlayer.CanExecuteChanged += value;
            }

            remove
            {
                AddPlayer.CanExecuteChanged -= value;
            }
        }

        public bool CanExecute(object? parameter)
        {
            return AddPlayer.CanExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            AddPlayer.Execute(parameter);
        }
    }
}