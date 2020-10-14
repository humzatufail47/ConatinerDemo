FROM mcr.microsoft.com/dotnet/core/aspnet AS AspRuntime
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk As SDK
WORKDIR /src
COPY *.csproj HttpAPIs/
WORKDIR /src/HttpAPIs
RUN dotnet restore "HttpAPIs.csproj"
COPY . .
RUN dotnet build "HttpAPIs.csproj" -c Release -o /app/Build

FROM SDK as publish 
RUN dotnet publish "HttpAPIs.csproj" -c Release -o /app/publish 

FROM AspRuntime As Final 
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet","HttpAPIs.dll"]