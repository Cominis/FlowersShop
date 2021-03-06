using FlowerEShopAPI.DAL.Repositories.RepositoryInterfaces.HelpersInterfaces;
using static FlowerEShopAPI.DAL.Entities.Product;

namespace FlowerEShopAPI.DAL.Repositories.Helpers
{
    public class EnumConverter : IEnumConverter
    {
        public StatusEnum StringToStatusEnum(string status)
        {
            return status switch
            {
                "Available" => StatusEnum.Available,
                "OutOfStock" => StatusEnum.OutOfStock,
                _ => throw new NotImplementedException("Unknown status type")
            };
        }
    }
}
