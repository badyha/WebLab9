# Pizza Web API

REST Web API для управління запасами піци.

## Запуск

```bash
dotnet restore
dotnet run
```

API буде доступна на:
- `http://localhost:5100`
- Swagger UI: `http://localhost:5100/swagger`

## Структура проекту

```
PizzaWebAPI/
├── Controllers/
│   └── PizzasController.cs        # REST endpoints
├── Models/
│   └── Pizza.cs                   # Data model
├── Services/
│   └── PizzaService.cs            # Business logic
├── Properties/
│   └── launchSettings.json
├── appsettings.json
├── Program.cs
└── PizzaWebAPI.csproj
```

## REST API Endpoints

### GET /api/pizzas
Отримати всі піци

```bash
curl http://localhost:5100/api/pizzas
```

### GET /api/pizzas/{id}
Отримати піцу за ID

```bash
curl http://localhost:5100/api/pizzas/1
```

### POST /api/pizzas
Створити нову піцу

```bash
curl -X POST http://localhost:5100/api/pizzas \
  -H "Content-Type: application/json" \
  -d '{
    "name": "Гавайська",
    "size": "Велика",
    "price": 200,
    "quantity": 5
  }'
```

### PUT /api/pizzas/{id}
Оновити піцу

```bash
curl -X PUT http://localhost:5100/api/pizzas/1 \
  -H "Content-Type: application/json" \
  -d '{
    "name": "Маргарита",
    "size": "Велика",
    "price": 160,
    "quantity": 12
  }'
```

### DELETE /api/pizzas/{id}
Видалити піцу

```bash
curl -X DELETE http://localhost:5100/api/pizzas/1
```

## Модель Pizza

```json
{
  "id": 1,
  "name": "Маргарита",
  "size": "Велика",
  "price": 150,
  "quantity": 10
}
```

## Технологія

- ASP.NET Core 8.0
- C#
- Swagger/OpenAPI
- CORS enabled

## Операції CRUD

- ✅ **C**reate (POST) - Додавання нової піци
- ✅ **R**ead (GET) - Отримання піц
- ✅ **U**pdate (PUT) - Оновлення піци
- ✅ **D**elete (DELETE) - Видалення піци
