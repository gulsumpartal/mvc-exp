using System.ComponentModel.DataAnnotations.Schema;
using MvcExample.Domain.Abstract;

namespace MvcExample.Domain.Department
{
    [Table("Department",Schema = "auth")]
    public class Department : EntityBase
    {
        public string Name { get; set; }
    }
}
