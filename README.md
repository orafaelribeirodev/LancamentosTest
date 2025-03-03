# 📌 Projeto - Controle de Fluxo de Caixa

## 📝 Introdução

Este projeto tem como objetivo fornecer um serviço para o controle de fluxo de caixa, permitindo o registro de lançamentos financeiros (créditos e débitos) e a obtenção de um relatório consolidado diário.

## 🛠 Tecnologias Utilizadas

- **C# .NET 7**
- **ASP.NET Core Web API**
- **Entity Framework Core (SQLite)**
- **Swagger para documentação da API**
- **XUnit para testes unitários**
- **Injeção de Dependência (Dependency Injection - DI)**
- **Docker para containerização** (futuro)

## 🚀 Como Rodar o Projeto Localmente

### **1. Clonar o repositório**

```bash
git clone https://github.com/seu-usuario/projeto-fluxo-caixa.git
cd projeto-fluxo-caixa
```

### **2. Configurar o Banco de Dados**

O projeto utiliza **SQLite** para persistência de dados. Execute os seguintes comandos para criar o banco e aplicar as migrations:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### **3. Rodar a Aplicação**

```bash
dotnet run --project Projeto.Api
```

A API estará disponível em:

```
http://localhost:5000/swagger
```

---

## 📌 Endpoints da API

### **Lançamentos**

#### Criar um novo lançamento

```http
POST /api/lancamentos
```

**Body:**

```json
{
  "valor": 100.00,
  "tipo": "Crédito"
}
```

**Resposta:**

```json
{
  "message": "Lançamento criado com sucesso!"
}
```

#### Obter lançamentos por data

```http
GET /api/lancamentos/{data}
```

**Resposta:**

```json
[
  {
    "id": "xxxx-xxxx",
    "valor": 100.00,
    "tipo": "Crédito",
    "data": "2025-02-27T12:00:00Z"
  }
]
```

---

## ✅ Testes

Para rodar os testes unitários, utilize:

```bash
dotnet test
```



