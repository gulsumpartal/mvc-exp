using System.ComponentModel.DataAnnotations.Schema;
using MvcExample.Domain.Abstract;

namespace MvcExample.Domain.Role
{
    [Table("Role",Schema = "auth")]
    public class Role :EntityBase
    {
        public string Name { get; set; }
    }
}
