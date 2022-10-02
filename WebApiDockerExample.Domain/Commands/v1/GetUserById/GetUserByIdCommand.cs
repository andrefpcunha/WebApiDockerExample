using MediatR;

namespace WebApiDockerExample.Domain.Commands.v1.GetUserById
{
    public class GetUserByIdCommand : IRequest<GetUserByIdResult>
    {
        public int Id { get; set; }
        public GetUserByIdCommand(int id)
        {
            Id = id;
        }
    }
}
