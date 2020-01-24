FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Facturacion.API/Facturacion.API.csproj", "Facturacion.API/"]
RUN dotnet restore "Facturacion.API/Facturacion.API.csproj"
COPY . .
WORKDIR "/src/Facturacion.API"
RUN dotnet build "Facturacion.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Facturacion.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Facturacion.API.dll"]