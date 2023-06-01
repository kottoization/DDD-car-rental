using DDD.SharedKernel.DomainModelLayer;
using DDD.SharedKernel.DomainModelLayer.Implementations;
using DDD.CarRental.Core.DomainModelLayer.Events;
using System;

namespace DDD.CarRental.Core.DomainModelLayer.Models
{
    public class Driver : Entity, IAggregateRoot
    {
        public string LicenceNumber { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public int FreeMinutes { get; protected set; }

        // konstruktor na potrzeby serializacji
        protected Driver()
        { }

        public Driver(long driverId, string licenceNumber, string firstName, string lastName, int freeMinutes)
            : base(driverId)
        {
            if (String.IsNullOrEmpty(licenceNumber)) throw new Exception("Licence number is null or empty");
            if (String.IsNullOrEmpty(firstName)) throw new Exception("First name is null or empty");
            if (String.IsNullOrEmpty(lastName)) throw new Exception("Last name is null or empty");
            if (freeMinutes < 0) throw new Exception("Free minutes cannot be negative");

            LicenceNumber = licenceNumber;
            FirstName = firstName;
            LastName = lastName;
            FreeMinutes = freeMinutes;
        }
    }

}
