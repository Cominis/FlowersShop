using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace FlowerEShopAPI.DAL.Entities
{
    public abstract class BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        [Timestamp]
        [JsonIgnore]
        public byte[] Timestamp { get; set; }
    }
}
