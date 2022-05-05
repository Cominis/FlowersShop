namespace FlowerEShopAPI.BL.Services.ServiceInterfaces
{
    public interface ILogsService
    {
        public Task LogAction(string userName, string className, string methodName, string message);
        public Task LogWarning(string userName, string className, string methodName, string message);
        public Task LogError(string userName, string className, string methodName, string message);
    }
}
