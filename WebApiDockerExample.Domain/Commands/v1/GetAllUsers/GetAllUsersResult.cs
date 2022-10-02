using WebApiDockerExample.Domain.Models;

namespace WebApiDockerExample.Domain.Commands.v1.GetAllUsers
{
    public class GetAllUsersResult : ResponseBase
    {
        public List<User>? Users { get; set; }
    }
}
