FROM mcr.microsoft.com/dotnet/sdk:6.0-bullseye-slim AS build
WORKDIR /app
EXPOSE 80
COPY FreeCourse.Gateway/*.csproj FreeCourse.Gateway/
RUN dotnet restore FreeCourse.Gateway/*.csproj
COPY . .
RUN dotnet publish FreeCourse.Gateway/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:6.0-bullseye-slim AS runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","FreeCourse.Gateway.dll" ]
