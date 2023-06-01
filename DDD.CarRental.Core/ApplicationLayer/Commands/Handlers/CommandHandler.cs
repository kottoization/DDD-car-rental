using DDD.CarRental.Core.DomainModelLayer.Factories;
using DDD.CarRental.Core.DomainModelLayer.Interfaces;
using DDD.CarRental.Core.DomainModelLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.CarRental.Core.ApplicationLayer.Commands.Handlers
{
    public class CommandHandler
    {
        //czesciowo zrobione 
        private CarFactory _carFactory;
        private ICarRentalUnitOfWork _unitOfWork;

        public void Execute(CreateCarCommand command)
        {
            Car car = this._unitOfWork.CarRepository.GetCarById(command.CarId);
            if(car != null)
                throw new Exception($"Car '{command.CarId}' already exists.");

            car = this._unitOfWork.CarRepository.GetCarByRegistration(command.RegistrationNumber);
            if (car != null)
                throw new Exception($"Car '{command.RegistrationNumber}' already exists.");

            // jeśli utworzenie obiektu (agregatu) jest proste,
            // wówczas tworzymy go bezpośrednio w serwisie aplikacyjnym
            car = new Car(command.CarId, command.RegistrationNumber, command.CurrentDistance, command.TotalDistance);

            this._unitOfWork.CarRepository.Insert(car);
            this._unitOfWork.Commit();
        }
    }
}
