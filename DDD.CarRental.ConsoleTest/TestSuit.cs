using DDD.CarRental.Core.ApplicationLayer.Commands;
using DDD.CarRental.Core.ApplicationLayer.Commands.Handlers;
using DDD.CarRental.Core.ApplicationLayer.Queries.Handlers;
using DDD.CarRental.Core.DomainModelLayer.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.CarRental.ConsoleTest
{
    public class TestSuit
    {
        private IServiceProvider _serviceProvide;

        private CommandHandler _commandHandler;
        private QueryHandler _queryHandler;

        public TestSuit(IServiceCollection serviceCollection)
        {
            _serviceProvide = serviceCollection.BuildServiceProvider();

            _commandHandler = _serviceProvide.GetRequiredService<CommandHandler>();
            _queryHandler = _serviceProvide.GetRequiredService<QueryHandler>();
        }

        public void Run()
        {
            // ToDo: scenariusz testowy

            long rental1Id = 11;
            long car1Id = 21;
            long driver1Id = 31;
            string registration1 = "KR001";
            double totalDistance1 = 1000;
            //tylko czesciowo zrobione
            _commandHandler.Execute(new CreateCarCommand()
            {
                // sprawdzic poprawnosc !!!!!!!!
                Status = CarStatusCommand.Free,
                CarId = car1Id,
                RegistrationNumber = registration1,
                CurrentDistance = 0,
                CurrentPosition = ("10,20"),
                TotalDistance = totalDistance1

            }); 
        }
    }
}
