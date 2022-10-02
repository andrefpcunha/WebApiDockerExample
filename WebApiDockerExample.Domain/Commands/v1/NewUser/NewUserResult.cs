using WebApiDockerExample.Domain.Models;

namespace WebApiDockerExample.Domain.Commands.v1.NewUser
{
    public class NewUserResult : ResponseBase
    {
        public int UserId { get; set; }
    }
}
