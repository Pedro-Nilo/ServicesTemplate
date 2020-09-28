using System;
using System.Threading.Tasks;
using R1Services.Domain.Models;


namespace R1Services.Domain.Interfaces.Services
{
    public interface IBaseService
    {
        Task<string> Request(RequestForm requestForm);

        Task<string> Chargeback(Guid transactionId);

        Task<string> Statement(Guid clientId);

        void Dispose();
    }
}