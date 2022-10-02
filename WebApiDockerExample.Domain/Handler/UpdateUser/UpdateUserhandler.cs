using MediatR;
using WebApiDockerExample.Domain.Commands.v1.UpdateUser;

namespace WebApiDockerExample.Domain.Handler.UpdateUser
{
    public class UpdateUserhandler : IRequestHandler<UpdateUserCommand, UpdateUserResult>
    {
        public async Task<UpdateUserResult> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            return new UpdateUserResult
            {
                Status = 200,
                Message = "User updated successfully!"
            };
        }
    }
}
