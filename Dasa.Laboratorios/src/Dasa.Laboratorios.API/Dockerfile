#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 53312
EXPOSE 44362

FROM microsoft/dotnet:2.1-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY ["src/Dasa.Laboratorios.API/Dasa.Laboratorios.API.csproj", "src/Dasa.Laboratorios.API/"]
RUN dotnet restore "src/Dasa.Laboratorios.API/Dasa.Laboratorios.API.csproj"
COPY . .
WORKDIR "/src/src/Dasa.Laboratorios.API"
RUN dotnet build "Dasa.Laboratorios.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Dasa.Laboratorios.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Dasa.Laboratorios.API.dll"]