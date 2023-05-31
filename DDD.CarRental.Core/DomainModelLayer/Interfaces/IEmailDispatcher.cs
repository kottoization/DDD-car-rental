using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DDD.CarRental.Core.DomainModelLayer.Interfaces
{
    public interface IEmailDispatcher
    {

        void Send(MailMessage mailMessage);
    }
}
