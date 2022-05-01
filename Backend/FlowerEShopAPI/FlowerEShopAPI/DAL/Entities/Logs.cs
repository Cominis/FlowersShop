using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FlowerEShopAPI.DAL.Entities
{
    public class Logs
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum TypeEnum
        {
            ACTION,
            WARNING,
            ERROR
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string LogType { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }

        [Required]
        public string ClassName { get; set; }

        [Required]
        public string MethodName { get; set; }

        public string Message { get; set; }
    }
}
