using FlowerEShopAPI.BL.Services.ServiceInterfaces;
using FlowerEShopAPI.DAL.Repositories.RepositoryInterfaces;
using static FlowerEShopAPI.DAL.Entities.Logs;

namespace FlowerEShopAPI.BL.Services
{
    public class LogsService : ILogsService
    {
        private readonly ILogsRepository _logsRepository;
        public LogsService(ILogsRepository logsRepository)
        {
            _logsRepository = logsRepository;
        }

        public async Task LogAction(string userName, string className, string methodName, string message)
        {
            await _logsRepository.AddLog(TypeEnum.ACTION, userName, className, methodName, message);
        }

        public async Task LogWarning(string userName, string className, string methodName, string message)
        {
            await _logsRepository.AddLog(TypeEnum.WARNING, userName, className, methodName, message);
        }

        public async Task LogError(string userName, string className, string methodName, string message)
        {
            await _logsRepository.AddLog(TypeEnum.ERROR, userName, className, methodName, message);
        }
    }
}
