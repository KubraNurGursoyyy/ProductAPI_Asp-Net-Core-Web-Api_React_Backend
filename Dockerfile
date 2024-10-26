FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src/ProductAPI_Asp-Net-Core-Web-Api_React

# Proje dosyalarını kopyala
COPY ProductAPI_Asp-Net-Core-Web-Api_React/ProductAPI/API/API.csproj ProductAPI/API/
COPY ProductAPI_Asp-Net-Core-Web-Api_React/ProductAPI/Business/Business.csproj ProductAPI/Business/
COPY ProductAPI_Asp-Net-Core-Web-Api_React/ProductAPI/DataAccess/DataAccess.csproj ProductAPI/DataAccess/
COPY ProductAPI_Asp-Net-Core-Web-Api_React/ProductAPI/DTO/DTO.csproj ProductAPI/DTO/
COPY ProductAPI_Asp-Net-Core-Web-Api_React/ProductAPI/Utils/Utils.csproj ProductAPI/Utils/

# Projeyi geri yükle
WORKDIR /src/ProductAPI_Asp-Net-Core-Web-Api_React/ProductAPI/API
RUN dotnet restore "./API.csproj"

# Projelerin tüm dosyalarını kopyala
COPY ProductAPI_Asp-Net-Core-Web-Api_React/ProductAPI/API/ ProductAPI/API/
COPY ProductAPI_Asp-Net-Core-Web-Api_React/ProductAPI/Business/ ProductAPI/Business/
COPY ProductAPI_Asp-Net-Core-Web-Api_React/ProductAPI/DataAccess/ ProductAPI/DataAccess/
COPY ProductAPI_Asp-Net-Core-Web-Api_React/ProductAPI/DTO/ ProductAPI/DTO/
COPY ProductAPI_Asp-Net-Core-Web-Api_React/ProductAPI/Utils/ ProductAPI/Utils/

WORKDIR /src/ProductAPI_Asp-Net-Core-Web-Api_React/ProductAPI/API
RUN dotnet build "./API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API.dll"]
