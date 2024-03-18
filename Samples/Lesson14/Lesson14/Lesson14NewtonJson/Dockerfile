FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Lesson14NewtonJson/Lesson14NewtonJson.csproj", "Lesson14NewtonJson/"]
RUN dotnet restore "Lesson14NewtonJson/Lesson14NewtonJson.csproj"
COPY . .
WORKDIR "/src/Lesson14NewtonJson"
RUN dotnet build "Lesson14NewtonJson.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Lesson14NewtonJson.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Lesson14NewtonJson.dll"]
