# /backend/Dockerfile
# Step 1: Use the official ASP.NET Core runtime image for the base image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80 

# Step 2: Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copy the project file and restore the dependencies
COPY ["TravelJournalAPI/TravelJournalAPI.csproj", "TravelJournalAPI/"]
RUN dotnet restore "TravelJournalAPI/TravelJournalAPI.csproj"

# Copy all the source code
COPY . .

# Build the app in Release mode and publish it
RUN dotnet publish "TravelJournalAPI.csproj" -c Release -o /app/publish

# Step 3: Use the runtime image to run the app
FROM base AS final
WORKDIR /app

# Copy the published app from the build stage
COPY --from=build /app/publish .

# Set the entry point for the container
ENTRYPOINT ["dotnet", "TravelJournalAPI.dll"]
