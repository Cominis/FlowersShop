using System.ComponentModel.DataAnnotations;

namespace FlowerEShopAPI.DAL.Entities
{
    public class User
    {
        public User(string userId, string name, string surname, string userName, string password)
        {
            UserId = userId;
            Name = name;
            Surname = surname;
            UserName = userName;
            Password = password;
        }

        [Key]
        public string UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public virtual List<Shop> Shop { get; set; }
    }
}
