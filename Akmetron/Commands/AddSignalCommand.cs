using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Akmetron.ViewModels;
using Akmetron.Models;

namespace Akmetron.Commands
{
    class AddSignalCommand:ICommand
    {
        private ProcedureViewModel viewModel;

        public AddSignalCommand(ProcedureViewModel viewModel)
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
            if (parameter != null)
            {
                if (parameter is Signal)
                {
                    return true;
                }
            }
            return false;
        }

        public void Execute(object parameter)
        {
            viewModel.AddSignal(parameter as Signal);
        }

        #endregion
    }
}
