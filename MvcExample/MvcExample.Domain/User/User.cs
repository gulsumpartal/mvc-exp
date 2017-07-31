using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using MvcExample.Domain.Abstract;

namespace MvcExample.Domain.User
{
    [Table("User",Schema = "auth")]
    public class User:EntityBase
    {
        [Required,MaxLength(25,ErrorMessage = "Kullanıcı Adı {1} karakterden fazla olamaz")]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Surname { get; set; }
    }
}
