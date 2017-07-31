namespace MvcExample.DTO.User
{
    public class UserDto
    {
        public string UserName { get; set; }
        public string  Firstname { get; set; }
        public string Lastname { get; set; }

        public string Fullname => $"{Firstname} {Lastname}";
    }
}
