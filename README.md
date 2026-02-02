# API CRUD Controller

A simple ASP.NET Core Web API project demonstrating CRUD (Create, Read, Update, Delete) operations for managing items.

## Overview

This project provides a RESTful API for managing a collection of items. The API uses in-memory storage, making it perfect for learning and testing purposes. All data is stored in a static list and will reset when the application restarts.

## Features

- **GET** all items
- **GET** a specific item by ID
- **POST** create a new item
- **PUT** update an existing item
- **DELETE** remove an item

## Technology Stack

- ASP.NET Core Web API
- C#
- OpenAPI/Swagger support (available in Development mode)

## Project Structure

```
WebAPIWithCrud/
├── Controllers/
│   └── ItemsController.cs    # Main CRUD controller
├── Models/
│   └── Item.cs               # Item data model
└── Program.cs                # Application entry point
```

## Item Model

```csharp
public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
}
```

- `Id`: Auto-generated unique identifier (integer)
- `Name`: Item name (string)

## API Endpoints

Base URL: `http://localhost:5198` (HTTP) or `https://localhost:7211` (HTTPS)

### 1. Get All Items
- **Method:** `GET`
- **URL:** `/api/items`
- **Response:** Array of all items
- **Status Codes:** 200 OK

### 2. Get Item by ID
- **Method:** `GET`
- **URL:** `/api/items/{id}`
- **Parameters:** `id` (integer) - The ID of the item
- **Response:** Item object
- **Status Codes:** 200 OK, 404 Not Found

### 3. Create Item
- **Method:** `POST`
- **URL:** `/api/items`
- **Headers:** `Content-Type: application/json`
- **Body:**
  ```json
  {
    "name": "Item Name"
  }
  ```
- **Response:** Created item with auto-generated ID
- **Status Codes:** 201 Created

### 4. Update Item
- **Method:** `PUT`
- **URL:** `/api/items/{id}`
- **Parameters:** `id` (integer) - The ID of the item to update
- **Headers:** `Content-Type: application/json`
- **Body:**
  ```json
  {
    "name": "Updated Item Name"
  }
  ```
- **Response:** No content
- **Status Codes:** 204 No Content, 404 Not Found

### 5. Delete Item
- **Method:** `DELETE`
- **URL:** `/api/items/{id}`
- **Parameters:** `id` (integer) - The ID of the item to delete
- **Response:** No content
- **Status Codes:** 204 No Content, 404 Not Found

## Getting Started

### Prerequisites

- .NET SDK (version compatible with the project)
- IDE (Visual Studio, VS Code, or Rider)

### Running the Application

1. Navigate to the project directory:
   ```bash
   cd WebAPIWithCrud
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Run the application:
   ```bash
   dotnet run
   ```

4. The API will be available at:
   - HTTP: `http://localhost:5198`
   - HTTPS: `https://localhost:7211`

5. (Optional) Access Swagger UI in Development mode:
   - Navigate to `http://localhost:5198/swagger` or `https://localhost:7211/swagger`

## Testing with Postman

### Recommended Testing Workflow

1. **Start the API** - Ensure the application is running

2. **Get All Items** (should return empty array initially)
   - GET `http://localhost:5198/api/items`

3. **Create Items** - Add a few test items
   - POST `http://localhost:5198/api/items`
   - Body: `{ "name": "Test Item 1" }`

4. **Get All Items** - Verify items were created
   - GET `http://localhost:5198/api/items`

5. **Get Specific Item** - Retrieve item by ID
   - GET `http://localhost:5198/api/items/1`

6. **Update Item** - Modify an existing item
   - PUT `http://localhost:5198/api/items/1`
   - Body: `{ "name": "Updated Item Name" }`

7. **Verify Update** - Confirm the change
   - GET `http://localhost:5198/api/items/1`

8. **Delete Item** - Remove an item
   - DELETE `http://localhost:5198/api/items/1`

9. **Verify Deletion** - Confirm item is removed
   - GET `http://localhost:5198/api/items/1` (should return 404)

### Postman Collection Setup Tips

- Create a collection named "Items API"
- Set a collection variable `baseUrl` = `http://localhost:5198`
- Use `{{baseUrl}}/api/items` in your requests
- Save requests for each endpoint for easy reuse

## Notes

- **In-Memory Storage**: All data is stored in memory and will be lost when the application restarts
- **Auto-Generated IDs**: The `Id` field is automatically assigned when creating items
- **PUT Requests**: Only include the `name` field in the request body; the `id` goes in the URL path

## License

This project is for educational purposes.
