FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS build
WORKDIR /src
COPY . .
RUN dotnet restore "./JobSityChat.StockBot/JobSityChat.StockBot.csproj"

FROM build AS publish
RUN dotnet publish "./JobSityChat.StockBot/JobSityChat.StockBot.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JobSityChat.StockBot.dll"]