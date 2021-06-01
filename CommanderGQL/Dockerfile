FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["StarPipeline.csproj", "."]
RUN dotnet restore "StarPipeline.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "StarPipeline.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "StarPipeline.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app/ .
ENTRYPOINT ["dotnet", "StarPipeline.dll"]