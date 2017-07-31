using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MvcExample.Domain.Abstract;

namespace MvcExample.Domain.User
{
    [Table("User",Schema = "auth")]
    public class User:EntityBase
    {
        [Required]
        public int RoleId { get; set; }
        [Required]
        public int DepartmentId { get; set; }

        [Required,MaxLength(25,ErrorMessage = "Kullanıcı Adı {1} karakterden fazla olamaz")]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Surname { get; set; }

        
        public Role.Role Role { get; set; }
        
        public Department.Department Department { get; set; }
    }
}
