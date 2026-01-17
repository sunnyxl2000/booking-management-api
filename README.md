# Booking Management API

A simple Booking Management REST API built with ASP.NET Core following Clean Architecture principles.

## Tech Stack
- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server (Docker)
- xUnit, Moq, FluentAssertions
- Swagger

## Architecture
- Api: HTTP layer
- Application: Business logic and services
- Domain: Core entities
- Infrastructure: Database access
- Tests: Unit tests for service layer

## How to Run Locally

### 1. Start SQL Server with Docker
```bash
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=StrongPwd123!" \
-p 1433:1433 --name booking-sql -d mcr.microsoft.com/mssql/server:2022-latest

### 2. Apply migrations
dotnet ef database update \
  --project Booking.Infrastructure \
  --startup-project Booking.Api

  ### 3. Run the API
  dotnet run --project Booking.Api

  ### 4. Open Swagger
  https://localhost:{port}/swagger

  ## Running Tests
  dotnet test

Features

Create bookings

Retrieve all bookings

Clean Architecture

Unit-tested service layer

1

