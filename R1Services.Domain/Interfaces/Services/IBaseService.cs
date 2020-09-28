using System.Threading.Tasks;


namespace R1Services.Domain.Core.Interfaces.Services
{
    public interface IBaseService
    {
        Task<string> Request();

        Task<string> Chargeback();

        Task<string> Statement();
    }
}