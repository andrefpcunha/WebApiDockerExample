FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ./src /src

RUN dotnet restore "WebApiDockerExample.sln"
RUN dotnet build "WebApiDockerExample.sln"

FROM  build AS publish
RUN dotnet publish "WebApiDockerExample.sln" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .

ENTRYPOINT ["dotnet", "WebApiDockerExample.dll"]