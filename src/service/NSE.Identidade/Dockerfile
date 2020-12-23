#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/service/NSE.Identidade/NSE.Identidade.csproj", "src/service/NSE.Identidade/"]
RUN dotnet restore "src/service/NSE.Identidade/NSE.Identidade.csproj"
COPY . .
WORKDIR "/src/src/service/NSE.Identidade"
RUN dotnet build "NSE.Identidade.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NSE.Identidade.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NSE.Identidade.dll"]