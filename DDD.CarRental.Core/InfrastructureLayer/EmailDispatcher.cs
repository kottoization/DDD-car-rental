using DDD.CarRental.Core.DomainModelLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DDD.CarRental.Core.InfrastructureLayer
{
    internal class EmailDispatcher : IEmailDispatcher
    {
        public void Send(MailMessage mailMessage)
        {
            // put email sending code here ...
        }
    }
}
