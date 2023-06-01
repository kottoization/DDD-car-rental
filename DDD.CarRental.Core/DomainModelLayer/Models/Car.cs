using DDD.SharedKernel.DomainModelLayer;
using DDD.SharedKernel.DomainModelLayer.Implementations;
using System;

namespace DDD.CarRental.Core.DomainModelLayer.Models
{
    public enum CarStatus
    {
        Available = 0,  // Samochód dostępny
        Rented = 1,     // Samochód wypożyczony
        InService = 2   // Samochód w serwisie
    }

    public class Car : Entity, IAggregateRoot
    {
        public string RegistrationNumber { get; protected set; }
        public double CurrentDistance { get; protected set; }
        public double TotalDistance { get; protected set; }
        public CarStatus Status { get; protected set; }

        // konstruktor na potrzeby serializacji
        protected Car()
        { }

        public Car(long carId, string registrationNumber, double currentDistance, double totalDistance)
            : base(carId)
        {
            if (String.IsNullOrEmpty(registrationNumber)) throw new Exception("Registration number is null or empty");
            if (currentDistance < 0) throw new Exception("Current distance cannot be negative");
            if (totalDistance < 0) throw new Exception("Total distance cannot be negative");

            RegistrationNumber = registrationNumber;
            CurrentDistance = currentDistance;
            TotalDistance = totalDistance;
            Status = CarStatus.Available;
        }
    }
}
