using Payment_APP.DTOs.User;
using Payment_APP.Queries;

namespace Payment_APP.UseCases.User
{
    public class RegisterUserQuery : IQuery<RegisterUserDto>
    {
        public string FullName { get; set; }
        public string Email { get; set; } 
        public string Password { get; set; }
    }
}
