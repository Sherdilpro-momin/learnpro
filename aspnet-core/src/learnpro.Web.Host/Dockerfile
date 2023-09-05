FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/learnpro.Web.Host/learnpro.Web.Host.csproj", "src/learnpro.Web.Host/"]
COPY ["src/learnpro.Web.Core/learnpro.Web.Core.csproj", "src/learnpro.Web.Core/"]
COPY ["src/learnpro.Application/learnpro.Application.csproj", "src/learnpro.Application/"]
COPY ["src/learnpro.Core/learnpro.Core.csproj", "src/learnpro.Core/"]
COPY ["src/learnpro.EntityFrameworkCore/learnpro.EntityFrameworkCore.csproj", "src/learnpro.EntityFrameworkCore/"]
WORKDIR "/src/src/learnpro.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/learnpro.Web.Host", "src/learnpro.Web.Host"]
COPY ["src/learnpro.Web.Core", "src/learnpro.Web.Core"]
COPY ["src/learnpro.Application", "src/learnpro.Application"]
COPY ["src/learnpro.Core", "src/learnpro.Core"]
COPY ["src/learnpro.EntityFrameworkCore", "src/learnpro.EntityFrameworkCore"]
WORKDIR "/src/src/learnpro.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "learnpro.Web.Host.dll"]
