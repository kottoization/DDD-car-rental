using DDD.SharedKernel.DomainModelLayer.Implementations;
using System;
using System.Collections.Generic;

namespace DDD.CarRental.Core.DomainModelLayer.Models
{
    public class Position : ValueObject
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }

        protected Position()
        {
        }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return X;
            yield return Y;
        }
    }

}
