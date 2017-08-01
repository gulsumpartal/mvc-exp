using System.Collections;

namespace MvcExample.DTO.News
{
    public class NewsDto : IEnumerable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
