using WebApiDockerExample.Domain.Models;

namespace WebApiDockerExample.Domain.Entities
{
    public class UserEntity : User
    {
        public bool Active { get; set; }
    }
}
