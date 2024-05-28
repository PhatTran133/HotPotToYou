# Xem https://aka.ms/customizecontainer để biết cách tùy chỉnh container gỡ lỗi của bạn và cách Visual Studio sử dụng Dockerfile này để xây dựng image của bạn nhanh hơn trong quá trình gỡ lỗi.

# Tùy thuộc vào hệ điều hành của máy chủ sẽ xây dựng hoặc chạy container, bạn có thể cần thay đổi image được chỉ định trong FROM statement.
# Để biết thêm thông tin, vui lòng xem https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["HotPotToYou/HotPotToYou.csproj", "HotPotToYou/"]
COPY ["HotPotToYou.Infrastructure/HotPotToYou.Infrastructure.csproj", "HotPotToYou.Infrastructure/"]
COPY ["HotPotToYou.Domain/HotPotToYou.Domain.csproj", "HotPotToYou.Domain/"]
RUN dotnet restore "./HotPotToYou/HotPotToYou.csproj"
COPY . .
WORKDIR "/src/HotPotToYou"
RUN dotnet build "./HotPotToYou.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./HotPotToYou.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HotPotToYou.dll"]
