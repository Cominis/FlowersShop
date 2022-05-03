using FlowerEShopAPI.Repositories.RepositoryInterfaces.HelpersInterfaces;
using static FlowerEShopAPI.DAL.Entities.Logs;
using static FlowerEShopAPI.DAL.Entities.Product;

namespace FlowerEShopAPI.Repositories.Helpers
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

        public TypeEnum StringToTypeEnum(string type)
        {
            return type switch
            {
                "ACTION" => TypeEnum.ACTION,
                "WARNING" => TypeEnum.WARNING,
                "ERROR" => TypeEnum.ERROR,
                _ => throw new NotImplementedException("Unknown type")
            };
        }
    }
}
