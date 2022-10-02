using MediatR;
using System.ComponentModel.DataAnnotations;

namespace WebApiDockerExample.Domain.Commands.v1.NewUser
{
    public class NewUserCommand : IRequest<NewUserResult>
    {
        [Required]
        public string? Name { get; set; }
        
        [Required]
        public string? Email { get; set; }
    }
}