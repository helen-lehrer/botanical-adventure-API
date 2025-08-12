# Stage 1: Build the app using the official .NET 6 SDK image
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

# Copy csproj and restore dependencies (use a wildcard if multiple projects)
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the files and build the release
COPY . ./
RUN dotnet publish -c Release -o out

# Stage 2: Build the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app

# Copy published output from build stage
COPY --from=build /app/out .

# Tell ASP.NET Core to listen on port 10000 (Render expects this)
ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000

# Replace 'BotanicalAdventure.dll' with your actual DLL name (check in out/)
ENTRYPOINT ["dotnet", "BotanicalAdventure.dll"]
