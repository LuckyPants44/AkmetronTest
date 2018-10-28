using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Akmetron.Models;
using Akmetron.Commands;
using Akmetron.Views;

namespace Akmetron.ViewModels
{
    class MainViewModel
    {
        private ObservableCollection<Signal> signals;
        private ProcedureViewModel childViewModel;

        public MainViewModel()
        {
            CreateCommand = new ProcedureCreateCommand(this);
        }

        public ObservableCollection<Signal> Signals
        {
            get { return signals; }
        }

        //Можем создать, если ещё не создавали
        public bool CanCreate
        {
            get
            {
                if (signals == null)
                {
                    return true;
                }
                return false;
            }
        }

        public void CreateProcedure()
        {
            signals = new ObservableCollection<Signal>();
            childViewModel = new ProcedureViewModel(signals);

            ProcedureWindow view = new ProcedureWindow();
            view.DataContext = childViewModel;
            //Скрыть текущую вьюшку
            view.ShowDialog();
            //Закрыть приложение
        }

        public ICommand CreateCommand
        {
            get;
            private set;
        }
    }
}
