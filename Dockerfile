FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ContosoPizza.csproj", "."]
RUN dotnet restore "./ContosoPizza.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "ContosoPizza.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ContosoPizza.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ContosoPizza.dll"]