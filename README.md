# ASP.NET MVC CRUD – Product Management

🛠️ **Complete CRUD Application** built with **ASP.NET Core MVC** (.NET 9.0), **Entity Framework Core** (Code-First), and **SQL Server**.  
Manage products easily: Create, Read, Update, Delete — with validation, responsive UI, and database persistence.

Perfect for learning modern .NET web apps, interviews, or portfolio showcase.

![Banner](https://via.placeholder.com/1200x400/0078d4/ffffff?text=Product+CRUD+App+-+.NET+9)  
<!-- Upload a real wide screenshot later and replace this URL with e.g. /screenshots/banner.png -->

## ✨ Features
- **Create** new products (name, price, description, category etc. – depending on your Product model)  
- **Read** / List all products with clean table view  
- **Update** / Edit product details  
- **Delete** products with confirmation prompt  
- Form validation using Data Annotations  
- Responsive design with **Bootstrap**  
- Database migrations for easy setup  
- Separation of concerns: Models, Views, Controllers, Data layer  

## 🛠️ Tech Stack
| Technology              | Purpose                              |
|-------------------------|--------------------------------------|
| ASP.NET Core MVC        | Web framework & routing              |
| .NET                    | 9.0                                  |
| Entity Framework Core   | ORM, Code-First migrations           |
| SQL Server (LocalDB)    | Database                             |
| C#                      | Backend logic                        |
| Bootstrap               | Responsive UI & components           |
| Razor Views             | Dynamic HTML                         |

![.NET](https://img.shields.io/badge/.NET-9.0-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Entity Framework](https://img.shields.io/badge/EF%20Core-512BD4?style=for-the-badge&logo=entity-framework&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)

## 🚀 Quick Start – Run Locally

### Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)  
- Visual Studio 2022 (ASP.NET workload) or VS Code + C# Dev Kit  
- SQL Server / LocalDB (auto-created via migrations)

### Steps (One-Time Setup)
1. Clone the repo
   ```bash
   git clone https://github.com/hanzla8/ASP.MVC_CRUD.git
   cd ASP.MVC_CRUD
   dotnet restore
   dotnet ef database update
   dotnet run

