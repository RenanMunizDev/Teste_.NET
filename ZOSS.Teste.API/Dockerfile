# Etapa base
FROM mcr.microsoft.com/dotnet/aspnet:9.0-preview AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Etapa build
FROM mcr.microsoft.com/dotnet/sdk:9.0-preview AS build
WORKDIR /src
COPY ["ZOSS.Teste.API/ZOSS.Teste.API.csproj", "ZOSS.Teste.API/"]
COPY ["ZOSS.Teste.Application/ZOSS.Teste.Application.csproj", "ZOSS.Teste.Application/"]
COPY ["ZOSS.Teste.Domain/ZOSS.Teste.Domain.csproj", "ZOSS.Teste.Domain/"]
COPY ["ZOSS.Teste.Infrastructure/ZOSS.Teste.Infrastructure.csproj", "ZOSS.Teste.Infrastructure/"]
RUN dotnet restore "ZOSS.Teste.API/ZOSS.Teste.API.csproj"
COPY . .
WORKDIR "/src/ZOSS.Teste.API"
RUN dotnet build "ZOSS.Teste.API.csproj" -c Release -o /app/build

# Etapa publish
FROM build AS publish
RUN dotnet publish "ZOSS.Teste.API.csproj" -c Release -o /app/publish

# Etapa final
FROM base AS final
WORKDIR /app

COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "ZOSS.Teste.API.dll"]