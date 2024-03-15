# Imagem base
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# SDK para compilação
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copiar arquivos do projeto e restaurar dependências
COPY ["MyProject.csproj", ""]
RUN dotnet restore "./MyProject.csproj"

# Copiar e compilar o código
COPY . .
WORKDIR "/src/."
RUN dotnet build "EmployeeApp.csproj" -c Release -o /app/build

# Publicar a aplicação
FROM build AS publish
RUN dotnet publish "EmployeeApp.csproj" -c Release -o /app/publish

# Configuração final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyProject.dll"]