using System;
using System.Collections.Generic;
using DDD.SharedKernel.DomainModelLayer.Implementations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.CarRental.Core.DomainModelLayer.Events
{
    public class DriverCreatedDomainEvent : DomainEvent
    {
        public long DriverId { get; private set; }
        public string LicenseNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long FreeMinutes { get; set; }

        public DriverCreatedDomainEvent(long id, string licenseNumber, string firstName, string lastName, long freeMinutes)
        {
            DriverId = id;
            LicenseNumber = licenseNumber;
            FirstName = firstName;
            LastName = lastName;
            FreeMinutes = freeMinutes;
        }
    }
}
