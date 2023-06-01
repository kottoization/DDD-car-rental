using DDD.CarRental.Core.ApplicationLayer.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.CarRental.Core.ApplicationLayer.DTOs
{
    public enum CarStatusDto
    {
        Free = 0,  // Samochód wolny
        Reserved = 1, // Samochód zarezerwowany
        Busy = 2  // Samochód zajęty
    }

    public class CarDto
    {
        public long Id { get; set; }
        public string RegistrationNumber { get; set; }
        public double CurrentDistance { get; set; }
        public double TotalDistance { get; set; }
        public string CurrentPosition { get; set; }
        public CarStatusDto Status { get; set; }
    }
}
