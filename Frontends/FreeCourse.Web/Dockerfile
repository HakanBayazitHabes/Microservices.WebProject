FROM mcr.microsoft.com/dotnet/sdk:6.0-bullseye-slim AS build
WORKDIR /app
EXPOSE 80
COPY Shared/FreeCourse.Shared/*.csproj Shared/FreeCourse.Shared/
COPY Frontends/FreeCourse.Web/*.csproj Frontends/FreeCourse.Web/
RUN dotnet restore Frontends/FreeCourse.Web/*.csproj
COPY . .
RUN dotnet publish Frontends/FreeCourse.Web/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:6.0-bullseye-slim AS runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "FreeCourse.Web.dll"] 