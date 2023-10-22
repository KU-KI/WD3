#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#https://hub.docker.com/_/microsoft-dotnet-sdk?ref=login

#https://hub.docker.com/_/microsoft-dotnet-aspnet
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
#Linux amd64 - Debian 11
#FROM mcr.microsoft.com/dotnet/aspnet:6.0.14-bullseye-slim-amd64 AS base
#Linux arm32 - Debian 10
#FROM mcr.microsoft.com/dotnet/aspnet:5.0.3-buster-slim-arm32v7 AS base
#Linux arm32 - Ubuntu 20.04
#FROM mcr.microsoft.com/dotnet/aspnet:5.0.3-focal-arm32v7 AS base
#Linux arm64 - Debian 11
#FROM mcr.microsoft.com/dotnet/aspnet:6.0.14-bullseye-slim-arm64v8 AS base
#FROM mcr.microsoft.com/dotnet/aspnet:5.0.3-buster-slim-arm64v8 AS base
#Linux arm64 - Ubuntu 20.04
#FROM mcr.microsoft.com/dotnet/aspnet:5.0.3-focal-arm64v8 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

#https://hub.docker.com/_/microsoft-dotnet-sdk
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
#FROM mcr.microsoft.com/dotnet/sdk:6.0.406-bullseye-slim-amd64 AS build
#FROM mcr.microsoft.com/dotnet/sdk:5.0.406-buster-slim-amd64 AS build
WORKDIR /src
COPY ["WD3.csproj", "."]
RUN dotnet restore "./WD3.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "WD3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WD3.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WD3.dll"]