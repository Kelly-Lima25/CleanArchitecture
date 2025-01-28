# CleanArchitecture
Este projeto foi desenvolvido com base no conteúdo ensinado por **José Carlos Macoratti**. Segui os passos apresentados na [playlist no YouTube](https://youtube.com/playlist?list=PLJ4k1IC8GhW3GICba2dLmiTZrVPw0SthC&si=u2dPl1qalTe8NxAY), onde ele aborda os conceitos de **Clean Architecture** para construir uma aplicação em ASP.NET Core. O sistema permite gerenciar produtos, incluindo operações de criação, leitura, atualização e exclusão (CRUD).

---

## 🚀 Tecnologias e Ferramentas
- **ASP.NET Core MVC**
- **Entity Framework Core**
- **SQL Server**
- **C#**
- **Visual Studio 2022**

---

## 📋 Pré-requisitos

Antes de começar, você precisa ter instalado:
- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/)

---

## 🛠️ Como configurar e executar

1. Clone este repositório:

   ```bash
   git clone [https://github.com/Kelly-Lima25/CleanArchitecture.git]
   
2. Configure a string de conexão no arquivo appsettings.json:
    - A string de conexão deve ser configurado de acordo o banco que for usado.
   
    "ConnectionStrings": {
    "DefaultConnection": "Server=SEU_SERVIDOR;Database=CleanArchDB;Trusted_Connection=True;"
    }
   
3. Execute no terminal a migração do banco de dados (no terminal na parte de *Default project* troca para CleanArch.Infra.Data):
   add-migration InicialDemo
   
4. Após executar a migração, atualize o banco de dados através do terminal:
   update-database
   
5. Execute o projeto no Visual Studio.
