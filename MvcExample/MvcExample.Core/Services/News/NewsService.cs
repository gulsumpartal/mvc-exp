using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcExample.DTO.News;
using MvcExample.DTO.User;

namespace MvcExample.Core.Services.News
{
    public class NewsService
    {
        private readonly DatabaseContext db;

        public NewsService()
        {
            db = new DatabaseContext();
        }

        public Boolean Add(NewsDto dto)
        {
            try
            {
                var data = new Domain.News
                {
                    Name = dto.Name,
                    Content = dto.Content
                };
                db.Newses.Add(data);

                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                
                throw;

            }
            
        }

        public List<NewsDto> GetNewses()
        {
            var response = db.Newses.Select(p=>new NewsDto
            {
                Name = p.Name,
                Content = p.Content
            }).ToList();
            return response;
        }
         
    }
}
