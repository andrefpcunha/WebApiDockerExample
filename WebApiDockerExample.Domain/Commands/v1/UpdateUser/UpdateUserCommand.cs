using MediatR;
using System.ComponentModel.DataAnnotations;

namespace WebApiDockerExample.Domain.Commands.v1.UpdateUser
{
    public class UpdateUserCommand : IRequest<UpdateUserResult>
    {
        [Required]
        public string? Name { get; set; }
    }
}