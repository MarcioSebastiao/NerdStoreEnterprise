#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/services/NSE.Pedidos/NSE.Pedidos.csproj", "src/services/NSE.Pedidos/"]
RUN dotnet restore "src/services/NSE.Pedidos/NSE.Pedidos.csproj"
COPY . .
WORKDIR "/src/src/services/NSE.Pedidos"
RUN dotnet build "NSE.Pedidos.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NSE.Pedidos.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NSE.Pedidos.dll"]