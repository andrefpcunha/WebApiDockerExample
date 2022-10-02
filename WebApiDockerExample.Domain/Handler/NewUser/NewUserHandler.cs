using MediatR;
using WebApiDockerExample.Domain.Commands.v1.NewUser;

namespace WebApiDockerExample.Domain.Handler.NewUser
{
    public class NewUserHandler : IRequestHandler<NewUserCommand, NewUserResult>
    {
        public async Task<NewUserResult> Handle(NewUserCommand request, CancellationToken cancellationToken)
        {
            return new NewUserResult
            {
                Status = 200,
                Message = $"User [{request.Name}] successfully added!",
                UserId = 1
            };
        }
    }
}
