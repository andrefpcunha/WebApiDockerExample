using MediatR;
using WebApiDockerExample.Domain.Commands.v1.DeleteUser;

namespace WebApiDockerExample.Domain.Handlers.DeleteUser
{
    public class DeleteHandler : IRequestHandler<DeleteUserCommand, DeleteUserResult>
    {
        public async Task<DeleteUserResult> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            return new DeleteUserResult
            {
                Status = 200,
                Message = "User deleted successfully!"
            };
        }
    }
}
