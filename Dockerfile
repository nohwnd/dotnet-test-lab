FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /app
COPY . /app/.
RUN dotnet build
RUN dotnet test "--logger:Console;verbosity=normal"
