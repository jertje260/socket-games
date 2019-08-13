FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Games.Frontend/Games.Frontend.csproj", "Games.Frontend/"]
RUN dotnet restore "Games.Frontend/Games.Frontend.csproj"
COPY . .
WORKDIR "/src/Games.Frontend"
RUN dotnet build "Games.Frontend.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Games.Frontend.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Games.Frontend.dll"]