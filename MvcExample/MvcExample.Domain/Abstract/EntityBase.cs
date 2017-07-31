using System;
using System.ComponentModel.DataAnnotations;

namespace MvcExample.Domain.Abstract
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
