using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace R1Services.Domain.Interfaces.Services
{
    public interface IBaseService
    {
        Task<string> Request(IFormCollection formCollection);

        Task<string> Chargeback(Guid transactionId);

        Task<string> Statement(Guid clientId);

        void Dispose();
    }
}