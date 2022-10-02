using WebApiDockerExample.Domain.Models;

namespace WebApiDockerExample.Domain.Commands.v1.GetUserById
{
    public class GetUserByIdResult : ResponseBase
    {
        public User User { get; set; }
    }
}
