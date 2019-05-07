FROM microsoft/dotnet:2.0-runtime-nanoserver-1709 AS base
WORKDIR /app

FROM microsoft/dotnet:2.0-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY 09.RefactorSpecialNumbers/09.RefactorSpecialNumbers.csproj 09.RefactorSpecialNumbers/
RUN dotnet restore 09.RefactorSpecialNumbers/09.RefactorSpecialNumbers.csproj
COPY . .
WORKDIR /src/09.RefactorSpecialNumbers
RUN dotnet build 09.RefactorSpecialNumbers.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish 09.RefactorSpecialNumbers.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "09.RefactorSpecialNumbers.dll"]
