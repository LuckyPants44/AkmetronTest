using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Akmetron.ViewModels;

namespace Akmetron.Commands
{
    internal class ProcedureCreateCommand : ICommand
    {
        private MainViewModel viewModel;

        public ProcedureCreateCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        #region ICommand Members

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return viewModel.CanCreate;
        }

        public void Execute(object parameter)
        {
            viewModel.CreateProcedure();
        }

        #endregion
    }
}
