using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.CarRental.Core.ApplicationLayer.Commands
{
    public enum CarStatusCommand
    {
        Free = 0,  // Samochód wolny
        Reserved = 1, // Samochód zarezerwowany
        Busy = 2  // Samochód zajęty
    }

    public class CreateCarCommand
    {
        public long CarId { get; set; }
        public string RegistrationNumber { get; set; }
        public double CurrentDistance { get; set; }
        public double TotalDistance { get; set; }
        public string CurrentPosition { get; set; }        
        public CarStatusCommand Status { get; set; }
    }
}
