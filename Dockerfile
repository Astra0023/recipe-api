# =========================
# Build stage
# =========================
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy solution and projects
COPY . .

# Restore dependencies
RUN dotnet restore

# Publish project
RUN dotnet publish recipe-api/recipe-api.csproj -c Release -o /app/publish

# =========================
# Runtime stage
# =========================
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

# Render provides PORT dynamically
ENV ASPNETCORE_URLS=http://+:$PORT

EXPOSE 8080

ENTRYPOINT ["dotnet", "recipe-api.dll"]