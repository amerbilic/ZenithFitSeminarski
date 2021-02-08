FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY . .

FROM build AS publish
RUN dotnet publish "ZenithFit.WebAPI" -c Release -o /app
FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ADD ./ZenithFit.WebAPI/Helpers ./Helpers

ENTRYPOINT ["dotnet", "ZenithFit.WebAPI.dll"]