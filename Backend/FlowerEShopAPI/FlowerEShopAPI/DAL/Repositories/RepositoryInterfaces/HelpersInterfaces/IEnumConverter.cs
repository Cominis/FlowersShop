using static FlowerEShopAPI.DAL.Entities.Product;

namespace FlowerEShopAPI.DAL.Repositories.RepositoryInterfaces.HelpersInterfaces
{
    public interface IEnumConverter
    {
        public StatusEnum StringToStatusEnum(string status);
    }
}
