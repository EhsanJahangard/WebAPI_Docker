#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.


FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source2
COPY . .
RUN dotnet restore "./service2.csproj" --disable-parallel
RUN dotnet publish "./service2.csproj" -c release -o /app --no-restore

# Serve stage
FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /app
COPY --from=build /app ./

EXPOSE 5002

ENTRYPOINT ["dotnet" , "service2.dll"]




#In the WSL OR SERVE Linux below Commands
# 0. cd C:\Users\Ehsan\source\repos\WebApplication_Docker\service2
# 1. docker build --rm -t appproduct/mycloud:latest .
# 2. docker image ls
# 3. docker run --rm --name ehsancontainer2 -p 5002:5002 -p 5003:5003 -e ASPNETCORE_HTTP_PORT=https://+:5003 -e ASPNETCORE_URLS=http://+:5002 appproduct/mycloud
# 4. docker ps
# 5. docker container stop idcontainer for example:
#		docker container stop 826664878ec4