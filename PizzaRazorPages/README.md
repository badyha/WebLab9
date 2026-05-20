# Pizza Razor Pages Application

ASP.NET Core Razor Pages застосунок для керування запасами піци.

## Запуск

```bash
dotnet restore
dotnet run
```

Додаток буде доступний на `http://localhost:5000`

## Структура проекту

```
PizzaRazorPages/
├── Pages/
│   ├── Index.cshtml              # Головна сторінка
│   ├── PizzaList.cshtml          # Список піц
│   └── CreatePizza.cshtml        # Форма для додавання піці
├── Properties/
│   └── launchSettings.json
├── wwwroot/                      # Статичні файли
├── appsettings.json
├── Program.cs
└── PizzaRazorPages.csproj
```

## Функціональність

- ✅ Перегляд списку піц
- ✅ Додавання нових піц
- ✅ Редагування піц (заготовка)
- ✅ Видалення піц (заготовка)

## Технологія

- ASP.NET Core 8.0
- Razor Pages
- C#
- Entity Framework Core

## Модель Pizza

```csharp
public class Pizza
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Size { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
```

## Сторінки

1. **Index** - Головна сторінка з навігацією
2. **PizzaList** - Відображення всіх піц в таблиці
3. **CreatePizza** - Форма для додавання нової піци
