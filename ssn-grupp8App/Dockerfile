## Använd .NET 9.X
#FROM mcr.microsoft.com/dotnet/sdk:9.* AS build-env
#
## Sätt arbetskatalogen
#WORKDIR /app
#
## Kopiera projektfilen och återställ beroenden
#COPY ./ssn-grupp8App/*.csproj ./ 
#RUN dotnet restore
#
## Kopiera övriga filer och bygg applikationen
#COPY ./ssn-grupp8App/. . 
#RUN dotnet publish -c Release -o /app/publish
#
## Kör den publicerade applikationen
#FROM mcr.microsoft.com/dotnet/aspnet:9.* AS runtime
#WORKDIR /app
#COPY --from=build-env /app/publish .
#
#CMD ["dotnet", "ssn-grupp8App.dll"]