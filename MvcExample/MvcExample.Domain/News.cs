using System.ComponentModel.DataAnnotations.Schema;
using MvcExample.Domain.Abstract;

namespace MvcExample.Domain
{
    [Table("News",Schema = "news")]
    public class News :EntityBase
    {
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
