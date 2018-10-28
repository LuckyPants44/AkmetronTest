using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Akmetron.Models;
using Akmetron.Commands;

namespace Akmetron.ViewModels
{
    internal class ProcedureViewModel: INotifyPropertyChanged
    {
        private ObservableCollection<Signal> signals;
        private Signal currentSignal;

        public ProcedureViewModel(ObservableCollection<Signal> signals)
        {
            Signals = signals;
            AddCommand = new AddSignalCommand(this);

            signals.Add(new SinusoidalSignal(1, 2, 3, 3));
        }

        public ObservableCollection<Signal> Signals
        {
            get { return signals; }
            set
            {
                signals = value;
                OnPropertyChanged("Signals");
            }
        }

        public Signal CurrentSignal
        {
            get { return currentSignal; }
            set
            {
                currentSignal = value;
                OnPropertyChanged("CurrentSignal");
            }
        }

        public ICommand AddCommand
        {
            get;
            private set;
        }

        public bool CanAdd
        {
            get
            {
                if (signals != null)
                {
                    return true;
                }
                return false;
            }
        }

        public void AddSignal(Signal signal)
        {
            signals.Add(signal);
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
