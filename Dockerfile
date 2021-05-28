FROM mcr.microsoft.com/dotnet/sdk as base

WORKDIR /app
COPY . .
RUN dotnet publish --configuration Debug -o out ClerkTracker.Client.Mvc

FROM mcr.microsoft.com/dotnet/aspnet

WORKDIR /run
COPY --from=base /app/out .
CMD [ "dotnet", "ClerkTracker.Client.Mvc.dll" ]