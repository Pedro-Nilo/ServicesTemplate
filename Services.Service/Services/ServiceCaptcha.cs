using System;
using System.Threading.Tasks;
using Services.Domain.Interfaces.Services;
using Services.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Http;

namespace Services.Service.Services
{
    public class ServiceCaptcha : IServiceCaptcha, IDisposable
    {
        private readonly IRepositoryTransaction _transactionRepository;

        public ServiceCaptcha(IRepositoryTransaction transactionRepository)
        {
            _transactionRepository = transactionRepository ??
                throw new ArgumentNullException(nameof(transactionRepository));
        }


        public async Task<string> Chargeback(Guid transactionId)
        {
            var transaction = await _transactionRepository.GetByGuidAsync(transactionId);

            //ToDo: Including Infra.CrossCutting for 2Captcha

            transaction.ChargedBack = true;

            _transactionRepository.Update(transaction);

            return "OK";
        }

        public Task<string> Request(IFormCollection formCollection)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> Statement(Guid clientId)
        {
            throw new System.NotImplementedException();
        }


        public void Dispose()
        {
            _transactionRepository.Dispose();
        }
    }
}