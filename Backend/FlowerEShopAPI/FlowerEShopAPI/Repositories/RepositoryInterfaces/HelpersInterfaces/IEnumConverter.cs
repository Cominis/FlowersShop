using static FlowerEShopAPI.DAL.Entities.Logs;
using static FlowerEShopAPI.DAL.Entities.Product;

namespace FlowerEShopAPI.Repositories.RepositoryInterfaces.HelpersInterfaces
{
    public interface IEnumConverter
    {
        public StatusEnum StringToStatusEnum(string status);
        public TypeEnum StringToTypeEnum(string type);
    }
}
