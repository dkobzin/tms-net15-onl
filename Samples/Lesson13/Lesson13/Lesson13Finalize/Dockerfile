FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Lesson13Finalize/Lesson13Finalize.csproj", "Lesson13Finalize/"]
RUN dotnet restore "Lesson13Finalize/Lesson13Finalize.csproj"
COPY . .
WORKDIR "/src/Lesson13Finalize"
RUN dotnet build "Lesson13Finalize.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Lesson13Finalize.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Lesson13Finalize.dll"]
