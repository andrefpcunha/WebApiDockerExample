using MediatR;
using System.Text.Json.Serialization;

namespace WebApiDockerExample.Domain.Commands.v1.UpdateUser
{
    public class UpdateUserCommand : IRequest<UpdateUserResult>
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string? Name { get; set; }

        public DateTime? Birthdate { get; set; }

        public bool? Active { get; set; }
    }
}