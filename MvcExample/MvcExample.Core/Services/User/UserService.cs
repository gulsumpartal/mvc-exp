using System.Linq;
using MvcExample.DTO.User;
namespace MvcExample.Core.Services.User
{
    public class UserService
    {
        private readonly DatabaseContext db;

        public UserService()
        {
           db = new DatabaseContext();
        }

        public UserDto GetuserDetail(UserLoginDto dto)
        {
            var data =
                db.Users.Where(p => p.Password.Trim() == dto.Password.Trim() 
                                    && p.Username.Trim() == dto.Username.Trim())
                    .Select(p => new UserDto
                    {
                        Firstname = p.Firstname,
                        Lastname = p.Surname,
                        UserName = p.Username
                    }).SingleOrDefault();
            return data;
        }
    }
}
