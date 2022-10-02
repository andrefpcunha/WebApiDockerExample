using MediatR;

namespace WebApiDockerExample.Domain.Commands.v1.UpdateUser
{
    public class UpdateUserCommand : IRequest<UpdateUserResult>
    {
        public string? Name { get; set; }

        public DateTime? Birthdate { get; set; }

        public bool? Active { get; set; }
    }
}