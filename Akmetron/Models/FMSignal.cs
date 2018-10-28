using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akmetron.Models
{
    public class FMSignal : Signal
    {
        private double modulatedSignalFrequency;

        public double ModulatedSignalFrequency
        {
            get { return modulatedSignalFrequency; }
            set
            {
                modulatedSignalFrequency = value;
                OnPropertyChanged("ModulatedSignalFrequency");
            }
        }

        public FMSignal(double frequency, double amplitude, int duration, double modulatedSignalFrequency) : base(frequency, amplitude, duration)
        {
            this.modulatedSignalFrequency = modulatedSignalFrequency;
            type = "FM";
        }    
    }
}
