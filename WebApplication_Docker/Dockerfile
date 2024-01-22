# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source
COPY . .
RUN dotnet restore "./WebApplication_Docker.csproj" --disable-parallel
RUN dotnet publish "./WebApplication_Docker.csproj" -c release -o /app --no-restore

# Serve stage
FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /app
COPY --from=build /app ./

EXPOSE 5000

ENTRYPOINT ["dotnet" , "WebApplication_Docker.dll"]



#In the WSL OR SERVE Linux below Commands
# 0. cd C:\Users\Ehsan\source\repos\WebApplication_Docker\WebApplication_Docker
######description below command docker build --rm -t repository:tag .
# 1. docker build --rm -t appproduct/mycloud:latest .
# 2. docker image ls
# 3. docker run --rm -p --name ehsancontainer1 5000:5000 -p 5001:5001 -e ASPNETCORE_HTTP_PORT=https://+:5001 -e ASPNETCORE_URLS=http://+:5000 appproduct/mycloud
# 4. docker ps
# 5. docker container stop idcontainer for example:
#		docker container stop 826664878ec4
