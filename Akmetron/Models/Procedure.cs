using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Akmetron.Models
{
    public class Procedure : INotifyPropertyChanged
    {
        private ObservableCollection<Signal> signals;

        public ObservableCollection<Signal> Signals
        {
            get { return signals; }
        }

        public void AddSignal(Signal signal)
        {
            signals.Add(signal);
            OnPropertyChanged("Signal Added");
        }

        public Procedure(ObservableCollection<Signal> signals)
        {
            this.signals = signals;
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
