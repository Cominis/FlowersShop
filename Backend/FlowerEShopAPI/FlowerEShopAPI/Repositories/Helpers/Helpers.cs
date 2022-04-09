using FlowerEShopAPI.Repositories.RepositoryInterfaces.HelpersInterfaces;

namespace FlowerEShopAPI.Repositories.Helpers
{
    public class Helpers : IHelpers
    {
        public Helpers()
        {

        }

        public bool IsStringEmty(string str)
        {
            if (str == null || str.Length == 0)
            {
                return true;
            }
            return false;
        }
    }
}
