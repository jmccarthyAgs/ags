FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["MyDockerWebApi/MyDockerWebApi.csproj", "MyDockerWebApi/"]
RUN dotnet restore "MyDockerWebApi/MyDockerWebApi.csproj"
COPY . .
WORKDIR "/src/MyDockerWebApi"
RUN dotnet build "MyDockerWebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MyDockerWebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MyDockerWebApi.dll"]