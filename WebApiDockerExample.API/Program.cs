using MediatR;
using Microsoft.AspNetCore.Mvc.Versioning;
using WebApiDockerExample.Domain.Handlers.DeleteUser;
using WebApiDockerExample.Domain.Handlers.GetAllUsers;
using WebApiDockerExample.Domain.Handlers.GetUserById;
using WebApiDockerExample.Domain.Handlers.NewUser;
using WebApiDockerExample.Domain.Handlers.UpdateUser;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApiVersioning(o =>
{
    o.AssumeDefaultVersionWhenUnspecified = true;
    o.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
    o.ReportApiVersions = true;
    o.ApiVersionReader = ApiVersionReader.Combine(
        new UrlSegmentApiVersionReader(),
        new MediaTypeApiVersionReader("ver"));

});

builder.Services.AddVersionedApiExplorer(
    options =>
    {
        options.GroupNameFormat = "'v'VVV";
        options.SubstituteApiVersionInUrl = true;
    });

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Handlers Injection
builder.Services.AddMediatR(typeof(GetAllUsersHandler));
builder.Services.AddMediatR(typeof(GetUserByIdHandler));
builder.Services.AddMediatR(typeof(NewUserHandler));
builder.Services.AddMediatR(typeof(UpdateUserhandler));
builder.Services.AddMediatR(typeof(DeleteHandler));
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
