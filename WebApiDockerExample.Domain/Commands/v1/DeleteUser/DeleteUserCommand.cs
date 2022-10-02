using MediatR;

namespace WebApiDockerExample.Domain.Commands.v1.DeleteUser
{
    public class DeleteUserCommand : IRequest<DeleteUserResult>
    {
        public int UserId { get; set; }
        public DeleteUserCommand(int id)
        {
            UserId = id;
        }
    }
}
