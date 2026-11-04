
# Acme Stock App

A Stock Management System built using **ASP.NET Core Web API** following the **N-Tier Architecture** pattern. The application provides product management functionality with secure authentication, authorization, email integration, and automated testing. It uses Microsoft SQL Server for data storage and Entity Framework Core for database operations.

## Features

- Manage products with complete CRUD operations (Create, Read, Update and Delete).
- N-Tier Architecture for separation of concerns and maintainable code.
- Authentication and Authorization to secure application access and resources.
- SMTP Email Integration for sending emails.
- Google reCAPTCHA v3 integration for bot protection and request validation.
- Unit Testing to verify individual application components.
- Integration Testing to verify interactions between application layers and the database.

## Tech Stack

- **Backend:** ASP.NET Core Web API, C#
- **Architecture:** N-Tier Architecture
- **Database:** Microsoft SQL Server
- **ORM:** Entity Framework Core (EF Core)
- **Email Service:** SMTP
- **Security:** Authentication, Authorization, Google reCAPTCHA v3
- **Testing:** xUnit, Unit Testing, Integration Testing

## How It Works

1. The application exposes RESTful API endpoints through ASP.NET Core Web API.
2. API requests are processed through separate application layers following N-Tier Architecture.
3. Entity Framework Core handles database operations with Microsoft SQL Server.
4. Users can perform product CRUD operations through the API.
5. Authentication and Authorization ensure secure access to protected resources.
6. SMTP integration handles email communication, while Google reCAPTCHA v3 helps protect against automated requests.
7. Unit and Integration Tests validate application functionality and layer interactions.

## Getting Started

**Prerequisites:** .NET 10 SDK, Microsoft SQL Server, Visual Studio 2026 (or any compatible IDE).

```bash
git clone https://github.com/MuhammadShahrooz125/Acme-Stock-App.git
cd Acme-Stock-App
```

Update the database connection string and configure the required SMTP and Google reCAPTCHA settings in your application configuration.

Run database migrations if required, then start the application:

```bash
dotnet restore
dotnet run
```

## Screenshots

_Add screenshots of the application and API functionality here._

## Author

Muhammad Shahrooz

[LinkedIn](https://linkedin.com/in/mshahrooz) | [GitHub](https://github.com/MuhammadShahrooz125)
