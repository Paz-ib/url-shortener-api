# URL Shortener API

A simple and efficient URL shortener built with ASP.NET Core.

## Overview

This project provides a REST API that allows users to shorten long URLs into compact, easy-to-share links.

When a shortened URL is accessed, the API automatically redirects the user to the original destination.

## Features

- Create short URLs from long links
- Redirect users using short codes
- In-memory database using Entity Framework Core
- Clean architecture with Controllers and Services
- Swagger UI for testing endpoints

## Technologies

- C#
- ASP.NET Core Web API
- Entity Framework Core (InMemory)
- Swagger (OpenAPI)

## Project Structure
UrlShortenerApi
├── Controllers
├── Models
├── Data
├── Services
├── Program.cs



## API Endpoints

### Create Short URL
**POST** `/api/url`

Example:

```http
POST /api/url?originalUrl=https://google.com
```

Response:
```json
{
  "id": 1,
  "originalUrl": "https://google.com",
  "shortCode": "abc123",
  "createdAt": "2026-03-22T..."
}
```

### Get URL by Code
**GET** `/api/url/{code}`

### Redirect to Original URL
**GET** `/r/{code}`
This endpoint redirects the user to the original URL.

## How to Run
```bash
git clone https://github.com/Paz-ib/url-shortener-api.git
cd url-shortener-api
dotnet run
```

Then open:
http://localhost:5019/swagger

Future Improvements
- Use persistent database (SQL Server / PostgreSQL)
- Add URL validation
- Implement DTOs
- Add click tracking
- Deploy to cloud (AWS / Azure)


## API Preview
![Swagger UI](screenshots/swagger.png)

Author
María Paz Ibarra