FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Lesson11Lambdas/Lesson11Lambdas.csproj", "Lesson11Lambdas/"]
RUN dotnet restore "Lesson11Lambdas/Lesson11Lambdas.csproj"
COPY . .
WORKDIR "/src/Lesson11Lambdas"
RUN dotnet build "Lesson11Lambdas.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Lesson11Lambdas.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Lesson11Lambdas.dll"]
