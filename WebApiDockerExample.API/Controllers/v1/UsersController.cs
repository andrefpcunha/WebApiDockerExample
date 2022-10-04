using Microsoft.AspNetCore.Mvc;
using MediatR;
using WebApiDockerExample.Domain.Commands.v1.GetAllUsers;
using WebApiDockerExample.Domain.Commands.v1.GetUserById;
using System.ComponentModel.DataAnnotations;
using WebApiDockerExample.Domain.Commands.v1.NewUser;
using WebApiDockerExample.Domain.Commands.v1.DeleteUser;
using WebApiDockerExample.Domain.Commands.v1.UpdateUser;

namespace WebApiDockerExample.API.Controllers.v1
{
    [ApiController]
    [Produces("application/json")]
    [Route("v{version:apiVersion}/[controller]")]
    //[ApiVersion("1.0")]
    public class UsersController : ControllerBase
    {
        #region Properties
        private IMediator Mediator { get; }
        private ILogger<UsersController> Logger { get; }
        #endregion


        #region Constructor
        public UsersController(
            IMediator mediator,
            ILogger<UsersController> logger)
        {
            Mediator = mediator;
            Logger = logger;
        }
        #endregion

        #region Actions

        ///// <summary>
        ///// Returns All users
        ///// </summary>
        ///// <returns>Returns successfully all Users</returns>
        [HttpGet()]
        [ProducesResponseType(typeof(GetAllUsersResult), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAll(CancellationToken cancellationToken)
        {
            Logger.LogInformation("Consulting All Users");
            var command = new GetAllUsersCommand();
            var response = await Mediator.Send(command, cancellationToken);
            return Ok(response);
        }


        ///// <summary>
        ///// Return an user by id
        ///// </summary>
        ///// <returns>Returns successfully the User by Id</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetUserByIdResult), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetById([Required] int id, CancellationToken cancellationToken)
        {
            Logger.LogInformation($"Consulting User by Id [{id}]");
            var command = new GetUserByIdCommand(id);
            var response = await Mediator.Send(command, cancellationToken);
            return Ok(response);
        }


        ///// <summary>
        ///// Adding a new User
        ///// </summary>
        ///// <returns>User added successfully</returns>
        [HttpPost()]
        [ProducesResponseType(typeof(NewUserResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Add([FromBody] NewUserCommand command, CancellationToken cancellationToken)
        {
            Logger.LogInformation("Creating a new User");
            var response = await Mediator.Send(command, cancellationToken);
            return Ok(response);
        }


        ///// <summary>
        ///// Updating a User
        ///// </summary>
        ///// <returns>User updated successfully</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(UpdateUserResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Update([Required] int id, [FromBody] UpdateUserCommand command, CancellationToken cancellationToken)
        {
            Logger.LogInformation("Updating the User");
            command.Id = id;
            var response = await Mediator.Send(command, cancellationToken);
            return Ok(response);
        }


        ///// <summary>
        ///// Removing a User
        ///// </summary>
        ///// <returns>User deleted successfully</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(DeleteUserResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Delete([Required] int id, CancellationToken cancellationToken)
        {
            Logger.LogInformation("Deleting the User");
            var command = new DeleteUserCommand(id);
            var response = await Mediator.Send(command, cancellationToken);
            return Ok(response);
        }

        #endregion
    }
}
