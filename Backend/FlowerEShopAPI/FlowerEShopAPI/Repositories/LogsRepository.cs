using FlowerEShopAPI.DAL;
using FlowerEShopAPI.DAL.Entities;
using FlowerEShopAPI.Repositories.RepositoryInterfaces;
using static FlowerEShopAPI.DAL.Entities.Logs;

namespace FlowerEShopAPI.Repositories
{
    public class LogsRepository : ILogsRepository
    {
        private readonly FlowerShopDBContext _context;
        public LogsRepository(FlowerShopDBContext context)
        {
            _context = context;
        }

        public async Task AddLog(TypeEnum type, string userName, string className, string methodName, string message)
        {
            var log = new Logs { LogType = type.ToString(), UserName = userName, TimeStamp = DateTime.Now, ClassName = className, MethodName = methodName, Message = message };

            _context.Logs.Add(log);
            await _context.SaveChangesAsync();
        }
    }
}
