using DDD.CarRental.Core.DomainModelLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.CarRental.Core.InfrastructureLayer.EF.EntityConfigurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
           

            // Ustaw nazwę tabeli
            builder.ToTable("Cars");

            // Ustaw klucz główny
            builder.HasKey(c => c.Id);

            // Konfiguruj pozostałe pola encji Car
            builder.Property(c => c.RegistrationNumber)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(c => c.CurrentDistance)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            
        }
    }
}
