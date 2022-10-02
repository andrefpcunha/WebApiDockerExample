using MediatR;
using WebApiDockerExample.Domain.Commands.v1.GetUserById;
using WebApiDockerExample.Domain.Models;

namespace WebApiDockerExample.Domain.Handlers.GetUserById
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdCommand, GetUserByIdResult>
    {
        public async Task<GetUserByIdResult> Handle(GetUserByIdCommand request, CancellationToken cancellationToken)
        {
            return new GetUserByIdResult
            {
                Status = 200,
                Message = "sucess",
                User = new User
                {
                    Id = 1,
                    Name = "André Cunha",
                    Email = "andre.cunha@email.com",
                    Birthdate = new DateTime(1985, 8, 8).ToString("yyyy-MM-dd")
                }
            };
        }
    }
}
