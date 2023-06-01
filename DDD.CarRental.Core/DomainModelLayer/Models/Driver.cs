using DDD.SharedKernel.DomainModelLayer;
using DDD.SharedKernel.DomainModelLayer.Implementations;
using DDD.CarRental.Core.DomainModelLayer.Events;
using System;

namespace DDD.CarRental.Core.DomainModelLayer.Models
{
    public class Driver : Entity, IAggregateRoot
    {
        public string LicenseNumber { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public long FreeMinutes { get; protected set; }

        protected Driver() { }

        public Driver(long driverId, string licenseNumber, string firstName, string lastName, string freeMinutes)
            : base(driverId)
        {
            if (String.IsNullOrEmpty(firstName)) throw new Exception("Player name is null or empty");
            if (String.IsNullOrEmpty(lastName)) throw new Exception("Player name is null or empty");
            if (String.IsNullOrEmpty(licenseNumber)) throw new Exception("License number cell is null or empty");
            if (String.IsNullOrEmpty(freeMinutes)) throw new Exception("Free minutes cell is null or empty");

            FirstName = firstName;
            LastName = lastName;
            LicenseNumber = licenseNumber;
            FreeMinutes = 0;

            this.AddDomainEvent(new DriverCreatedDomainEvent(this.Id, this.FirstName.ToString(), this.LastName.ToString(), this.LicenseNumber.ToString(), this.FreeMinutes));
        }
    }

}
