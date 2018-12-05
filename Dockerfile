FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
#EXPOSE 64341
#EXPOSE 44300

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Pesquisa/Pesquisa.csproj", "Pesquisa/"]
RUN dotnet restore "Pesquisa/Pesquisa.csproj"
COPY . .
WORKDIR "/src/Pesquisa"
RUN dotnet build "Pesquisa.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Pesquisa.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Pesquisa.dll"]