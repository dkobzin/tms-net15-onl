FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Lesson11Delegate/Lesson11Delegate.csproj", "Lesson11Delegate/"]
RUN dotnet restore "Lesson11Delegate/Lesson11Delegate.csproj"
COPY . .
WORKDIR "/src/Lesson11Delegate"
RUN dotnet build "Lesson11Delegate.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Lesson11Delegate.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Lesson11Delegate.dll"]
