using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Akmetron.Models
{
    public class Signal: INotifyPropertyChanged, IDataErrorInfo
    {
        private double frequency;
        private double amplitude;
        private int duration;
        protected string type;

        public double Frequency
        {
            get { return frequency; }
            set
            {
                frequency = value;
                OnPropertyChanged("Frequency");
            }
        }

        public double Amplitude
        {
            get { return amplitude; }
            set
            {
                amplitude = value;
                OnPropertyChanged("Amplitude");
            }
        }

        public int Duration
        {
            get { return duration; }
            set
            {
                duration = value;
                OnPropertyChanged("Duration");
            }
        }

        public string Type
        {
            get { return type; }
        }

        public Signal(double frequency, double amplitude, int duration)
        {
            this.frequency = frequency;
            this.amplitude = amplitude;
            this.duration = duration;
            type = "Обычный сигнал";
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region IDataErrorInfo Members

        public string Error
        {
            get;
            private set;
        }

        public string this[string columnName]
        {
            get
            {
                if(columnName == "Frequency")
                {
                    Error = "Какая-то ошибка!";
                }
                else
                {
                    Error = "Empty";
                }
                return Error;
            }
        }

        #endregion
    }
}
