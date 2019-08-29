FROM microestc/aspnet-2.2-stretch-magickoffice:0.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["DockerTest/DockerTest.csproj", "DockerTest/"]
COPY ["OfficeConverter/OfficeConverter.csproj", "OfficeConverter/"]
RUN dotnet restore "DockerTest/DockerTest.csproj"
COPY . .
WORKDIR "/src/DockerTest"
RUN dotnet build "DockerTest.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "DockerTest.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DockerTest.dll"]
