# Language Management API

This project is an ASP.NET Core Web API designed to manage language and culture-related information. It demonstrates a layered architecture and the implementation of the Mediator pattern for handling application logic.

## Project Structure

The solution is organized into the following layers:

*   **LanguageManagement.API**: The presentation layer, responsible for handling HTTP requests and responses. This is the entry point of the application.
*   **LanguageManagement.Application**: Contains application logic, including service interfaces, DTOs (Data Transfer Objects), and the Mediator pattern implementation.
    *   **Interfaces**: Defines contracts for services and mediators (e.g., `ICultureService`, `ILanguageMediator`).
    *   **Mediator**: The `LanguageMediator` class orchestrates actions, decoupling controllers from specific service implementations.
*   **LanguageManagement.Domain**: Contains core domain entities (e.g., `Language`).
*   **LanguageManagement.Infrastructure**: Implements external concerns, such as data access or communication with external services (e.g., `CultureService` which calls an external API).

## Features

*   Fetches a list of cultures from an external API.
*   Uses the Mediator pattern to decouple the API controller from the culture service.
*   Demonstrates a clean, layered architecture.

## Getting Started

### Prerequisites

*   .NET 8.0 SDK (or later)
*   An IDE like Visual Studio or VS Code (optional, but helpful)

### Building the Project

1.  Clone the repository:
    ```bash
    git clone <repository-url>
    cd <repository-directory>
    ```
2.  Build the solution. This will restore NuGet packages as well.
    ```bash
    dotnet build LanguageManagement.API.sln
    ```

### Running the Project

1.  Navigate to the API project directory:
    ```bash
    cd LanguageManagement.API
    ```
2.  Run the application:
    ```bash
    dotnet run
    ```
    The API will typically be available at `https://localhost:port` or `http://localhost:port` (the specific port numbers will be shown in the console output).

### Configuration

The application fetches culture data from an external API. The URL for this API is configured in `LanguageManagement.API/appsettings.json`:

```json
{
  "CultureApiSettings": {
    "CultureApiUrl": "https://run.mocky.io/v3/d893f0e0-30cb-4000-8425-60ad51c93b53"
  },
  // ... other settings
}
```
The `CultureApiUrl` is set to a mock API endpoint used during development.

## API Usage Example

Once the application is running, you can fetch the list of cultures using a tool like `curl`, Postman, or your web browser:

**Request:**

`GET /api/Language`

**Example using curl:**

```bash
curl http://localhost:5000/api/Language
```
(Adjust the port number if necessary. Check the console output when you run the application.)

**Successful Response (200 OK):**

The API will return a JSON array of culture data. For example:

```json
[
  {
    "id": "af-ZA",
    "name": "Afrikaans (South Africa)",
    "englishName": "Afrikaans (South Africa)",
    "nativeName": "Afrikaans (Suid-Afrika)",
    "language": "af"
  },
  // ... more culture data
]
```

## Mediator Pattern Implementation

The `LanguageController` uses the `ILanguageMediator` to request culture data. The `LanguageMediator` then coordinates with `ICultureService` to fetch this data. This decouples the controller from the direct implementation details of the service, making the application more modular and easier to maintain.
