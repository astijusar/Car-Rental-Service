#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["IdentityAPI/IdentityAPI.csproj", "IdentityAPI/"]
COPY ["JWT/bin/Debug/net6.0/JWT.dll", "app/JWT"]
RUN dotnet restore "IdentityAPI/IdentityAPI.csproj"
COPY . .
WORKDIR "/src/IdentityAPI"
RUN dotnet build "IdentityAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IdentityAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IdentityAPI.dll"]