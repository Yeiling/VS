FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["PM.WebApi/PM.WebApi.csproj", "PM.WebApi/"]
RUN dotnet restore "PM.WebApi/PM.WebApi.csproj"
COPY . .
WORKDIR "/src/PM.WebApi"
RUN dotnet build "PM.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "PM.WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "PM.WebApi.dll"]