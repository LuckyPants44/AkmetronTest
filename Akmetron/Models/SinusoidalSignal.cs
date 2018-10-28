using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akmetron.Models
{
    public class SinusoidalSignal : Signal
    {
        private double phaseShift;

        public double PhaseShift
        {
            get { return phaseShift; }
            set
            {
                phaseShift = value;
                OnPropertyChanged("PhaseShift");
            }
        }

        public SinusoidalSignal(double frequency, double amplitude, int duration, double phaseShift) : base(frequency, amplitude, duration)
        {
            this.phaseShift = phaseShift;
            type = "Синусоидальный";
        }
    }
}
