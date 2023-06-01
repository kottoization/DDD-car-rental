using DDD.CarRental.Core.DomainModelLayer.Models;
using DDD.SharedKernel.DomainModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.CarRental.Core.DomainModelLayer.Factories
{
    public class CarFactory
    {
        private IDomainEventPublisher _domainEventPublisher;

        public CarFactory(IDomainEventPublisher domainEventPublisher)
        {
            this._domainEventPublisher = domainEventPublisher;
        }

        public Car Create(long carId, string registrationNumber, double currentDistance)
        {
            // Wykonaj dodatkowe walidacje lub logikę związane z tworzeniem samochodu

            return new Car(carId, registrationNumber, currentDistance,0);
        }
    }
}
