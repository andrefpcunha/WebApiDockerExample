using MediatR;

namespace WebApiDockerExample.Domain.Commands.v1.GetAllUsers
{
    public class GetAllUsersCommand : IRequest<GetAllUsersResult>
    {
    }
}
