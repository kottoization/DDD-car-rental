using DDD.CarRental.Core.DomainModelLayer.Interfaces;
using DDD.CarRental.Core.DomainModelLayer.Models;
using DDD.CarRental.Core.InfrastructureLayer.EF;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DDD.CarRental.Core.InfrastructureLayer.EF
{
    public class CarRepository : Repository<Car>, ICarRepository
    { 
        public CarRepository(CarRentalDbContext context)
            :base(context)
        { }

        public IList<Car> GetAllCars()
        {
            //zweryfikowac pozniej czy nie trzeba tutaj cos dodac zeby zwracalo cos wicej niz tylko obiekt auta
            return _context.Cars
                .ToList();
        }

        public Car GetCarById(long id)
        {
            return _context.Cars.Where(c=>c.Id==id).FirstOrDefault();
        }

        public Car GetCarByRegistration(string RegistrationNumber)
        {
            return _context.Cars
                .Where(c => c.RegistrationNumber == RegistrationNumber)
                .FirstOrDefault();
        }
    }
}
