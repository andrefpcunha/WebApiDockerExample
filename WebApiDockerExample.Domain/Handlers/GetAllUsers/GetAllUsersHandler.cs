﻿using MediatR;
using WebApiDockerExample.Domain.Commands.v1.GetAllUsers;
using WebApiDockerExample.Domain.Models;

namespace WebApiDockerExample.Domain.Handlers.GetAllUsers
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersCommand, GetAllUsersResult>
    {
        public async Task<GetAllUsersResult> Handle(GetAllUsersCommand request, CancellationToken cancellationToken)
        {
            return new GetAllUsersResult
            {
                Status = 200,
                Message = "sucess",
                Users = new List<User> {
                    new User
                    {
                        Id = 1,
                        Name = "André Cunha",
                        Email = "andre.cunha@email.com",
                        Birthdate = new DateTime(1985,8,8).ToString("yyyy-MM-dd")
                    },
                    new User
                    {
                        Id = 2,
                        Name = "User Name",
                        Email = "user.name@email.com",
                        Birthdate = new DateTime(2000,12,31).ToString("yyyy-MM-dd")
                    }
                }
            };
        }
    }
}
