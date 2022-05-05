using static FlowerEShopAPI.DAL.Entities.Logs;

namespace FlowerEShopAPI.Repositories.RepositoryInterfaces
{
    public interface ILogsRepository
    {
        public Task AddLog(TypeEnum type, string userName, string className, string methodName, string message);
    }
}
