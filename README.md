# ASP.NET Core - Веб-застосування

Два ASP.NET Core проекти для керування запасами піци.

## Проекти

### 1. PizzaRazorPages/
**Razor Pages Application**

Веб-застосування з Razor Pages для керування запасами піци.

```bash
cd PizzaRazorPages
dotnet restore
dotnet run
```

Сайт: `http://localhost:5000`

**Функціональність:**
- Перегляд списку піц
- Додавання нових піц
- Редагування/видалення (готовиться)
- Beautiful UI з кольоровими кнопками

### 2. PizzaWebAPI/
**REST Web API**

REST API для CRUD операцій з піцами.

```bash
cd PizzaWebAPI
dotnet restore
dotnet run
```

API: `http://localhost:5100`
Swagger: `http://localhost:5100/swagger`

**Операції:**
- GET /api/pizzas - Отримати всі піци
- GET /api/pizzas/{id} - Отримати піцу по ID
- POST /api/pizzas - Додати нову піцу
- PUT /api/pizzas/{id} - Оновити піцу
- DELETE /api/pizzas/{id} - Видалити піцу

## Структура проекту

```
9/
├── PizzaRazorPages/
│   ├── Pages/
│   │   ├── Index.cshtml
│   │   ├── PizzaList.cshtml
│   │   └── CreatePizza.cshtml
│   ├── Program.cs
│   └── README.md
├── PizzaWebAPI/
│   ├── Controllers/
│   │   └── PizzasController.cs
│   ├── Models/
│   │   └── Pizza.cs
│   ├── Services/
│   │   └── PizzaService.cs
│   ├── Program.cs
│   └── README.md
└── README.md
```

## Технологія

- **Framework:** ASP.NET Core 8.0
- **Language:** C#
- **Data:** In-Memory Service (легко розширити до БД)
- **API Docs:** Swagger/OpenAPI
- **CORS:** Enabled для фронтенду

## Запуск обох проектів

**Термінал 1 - Razor Pages:**
```bash
cd PizzaRazorPages && dotnet run
```

**Термінал 2 - Web API:**
```bash
cd PizzaWebAPI && dotnet run
```

## Модель даних

```csharp
public class Pizza
{
    public int Id { get; set; }
    public string Name { get; set; }      // Назва піци
    public string Size { get; set; }      // Розмір
    public decimal Price { get; set; }    // Ціна
    public int Quantity { get; set; }     // Кількість на складі
}
```

## Приклади даних

- Маргарита (150₴) - 10 шт
- Пепероні (180₴) - 5 шт
- Чотири сири (220₴) - 8 шт

## Наступні кроки

1. Підключити База Даних (SQL Server / SQLite)
2. Реалізувати Entity Framework Core
3. Додати логування та обробку помилок
4. Написати Unit Tests
5. Розширити UI для редагування/видалення
