#API de Gerenciamento de Produtos

Uma API simples para gerenciamento de produtos, com operações CRUD (Criar, Ler, Atualizar e Deletar). Desenvolvida com .NET Core 8.0 e utilizando o Entity Framework Core para persistência de dados.

🚀 Como Rodar o Projeto Localmente

📋 Requisitos
SQL Server Local ou outro banco de dados de sua escolha (pode usar SQL Server LocalDB ou uma instância do SQL Server).

Visual Studio ou Visual Studio Code para desenvolvimento local.

.NET SDK instalado na sua máquina para compilar e rodar o projeto.

🔧 Passos para Rodar o Projeto

1️⃣ Clone o Repositório
   git clone https://github.com/seu-usuario/WebApiCoordly.git

2️⃣ Aplicar as Migrações e Criar o Banco de Dados

dotnet ef database update --project WebApiCoordly.Infrastructure --startup-project WebApiCoordly.Api

5️⃣ Rodar a API Localmente

Depois de aplicar as migrações, inicie o servidor localmente com:

dotnet run
