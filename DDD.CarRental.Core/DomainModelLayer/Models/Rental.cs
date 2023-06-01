using DDD.SharedKernel.DomainModelLayer;
using DDD.SharedKernel.DomainModelLayer.Implementations;
using System;
using System.Text;

namespace DDD.CarRental.Core.DomainModelLayer.Models
{
    public class Rental : Entity, IAggregateRoot
    {
        public DateTime Started { get; protected set; }
        public DateTime Finished { get; protected set; }
        public double Total { get; protected set; }

        // konstruktor na potrzeby serializacji
        protected Rental()
        { }

        public Rental(long rentalId, DateTime started, DateTime finished, double total)
            : base(rentalId)
        {
            if (started >= finished) throw new Exception("Start date must be before end date");
            if (total < 0) throw new Exception("Total cannot be negative");

            Started = started;
            Finished = finished;
            Total = total;
        }
    }

}
