using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerEShopAPI.DAL.Entities
{
    public class User
    {
        public User(string name, string surname, string userName, string password)
        {
            Name = name;
            Surname = surname;
            UserName = userName;
            Password = password;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required]
        public string UserName { get; set; } // PR
        [Required]
        [StringLength(50)]
        public string Password { get; set; } //PR

        public virtual Shop? Shop { get; set; }
    }
}
