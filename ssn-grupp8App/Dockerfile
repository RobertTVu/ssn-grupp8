## Anv�nd .NET 9.X
#FROM mcr.microsoft.com/dotnet/sdk:9.* AS build-env
#
## S�tt arbetskatalogen
#WORKDIR /app
#
## Kopiera projektfilen och �terst�ll beroenden
#COPY ./ssn-grupp8App/*.csproj ./ 
#RUN dotnet restore
#
## Kopiera �vriga filer och bygg applikationen
#COPY ./ssn-grupp8App/. . 
#RUN dotnet publish -c Release -o /app/publish
#
## K�r den publicerade applikationen
#FROM mcr.microsoft.com/dotnet/aspnet:9.* AS runtime
#WORKDIR /app
#COPY --from=build-env /app/publish .
#
#CMD ["dotnet", "ssn-grupp8App.dll"]