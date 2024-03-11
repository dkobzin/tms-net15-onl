FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Lesson10TestQ8/Lesson10TestQ8.csproj", "Lesson10TestQ8/"]
RUN dotnet restore "Lesson10TestQ8/Lesson10TestQ8.csproj"
COPY . .
WORKDIR "/src/Lesson10TestQ8"
RUN dotnet build "Lesson10TestQ8.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Lesson10TestQ8.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Lesson10TestQ8.dll"]
