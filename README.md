
# 🚀 Teste Técnico - API .NET 9

![CI/CD](https://github.com/RenanMunizDev/Teste_.NET/actions/workflows/ci.yml/badge.svg)

Olá recrutador(a)! 👋

Este repositório apresenta o desenvolvimento de um **teste técnico** para a vaga de **Desenvolvedor(a) .NET**, demonstrando domínio de **boas práticas**, **Clean Architecture**, separação clara por camadas, uso de **Entity Framework Core**, **MySQL**, **Swagger**, **Docker** e pipeline **CI/CD** com **GitHub Actions** para build, testes e publicação automática da imagem no **Docker Hub**.

---

## 📌 Descrição do Projeto

API RESTful construída em **.NET 9**, com o objetivo de gerenciar **Produtos** vinculados a suas **Categorias**.

Funcionalidades implementadas:
- ✅ Cadastro de Categorias
- ✅ Listagem de Categorias
- ✅ CRUD completo de Produtos (Cadastrar, Listar, Atualizar, Remover)
- ✅ Validações de entrada (DTOs)
- ✅ Documentação interativa via Swagger
- ✅ Orquestração via Docker Compose
- ✅ Pipeline CI/CD automatizado (build, testes e push da imagem Docker)

---

## 🗂️ Estrutura de Pastas

```plaintext
├── ZOSS.Teste.API             # Camada de apresentação (Controllers, Program.cs)
├── ZOSS.Teste.Application     # Regras de negócio, DTOs e Interfaces de Serviço
├── ZOSS.Teste.Domain          # Entidades e Interfaces de Repositório
├── ZOSS.Teste.Infrastructure  # Implementação de Repositórios, Migrations EF Core
├── docker-compose.yml         # Orquestração Docker para API + Banco de Dados
```

---

## ⚙️ Tecnologias Utilizadas

- [.NET 9](https://dotnet.microsoft.com/)
- [Entity Framework Core](https://learn.microsoft.com/ef/)
- [MySQL](https://www.mysql.com/)
- [Swagger / Swashbuckle](https://swagger.io/)
- [Docker](https://www.docker.com/)
- [GitHub Actions](https://github.com/features/actions)

---

## 🚀 Como Executar o Projeto

### 1️⃣ Pré-requisitos

- Docker e Docker Compose instalados
- .NET 9 SDK instalado (caso deseje rodar sem Docker)

---

### 2️⃣ Executar com Docker

No terminal, na raiz do projeto, execute:

```bash
docker-compose up --build
```

Este comando inicializa:
- API .NET 9 rodando em `http://localhost:8080`
- Banco de Dados MySQL rodando na porta `3306`

---

### 3️⃣ Testar Endpoints

Acesse a documentação Swagger em:
```
http://localhost:8080/swagger
```

Principais endpoints:
- `POST /category` → Cadastrar Categoria
- `GET /categories` → Listar Categorias
- `POST /product` → Cadastrar Produto
- `GET /products` → Listar Produtos
- `PUT /product/{id}` → Atualizar Produto
- `DELETE /product/{id}` → Remover Produto

---

## 🚀 CI/CD - Pipeline Automatizado

Este repositório possui pipeline **CI/CD** configurado com **GitHub Actions**, que realiza automaticamente:
- Build e testes do projeto .NET
- Build da imagem Docker usando o Dockerfile
- Push automático da imagem para o **[Docker Hub](https://hub.docker.com/repository/docker/renanmunizdev/teste-net-api/general)**

---

## ✅ Boas Práticas Aplicadas

- Padrão **DDD simplificado** com camadas **Domain**, **Application**, **Infrastructure** e **API**
- **Dependency Injection** configurado
- Validações claras via DTOs
- Separação de DTOs para **Request** e **Response**
- Versionamento de banco com **Migrations EF Core**
- **Docker Compose** para ambiente isolado
- **GitHub Actions** para pipeline CI/CD robusto e automatizado

---

## 🙌 Contato

Feito com dedicação por [Renan Muniz](https://github.com/RenanMunizDev)

💼 Pronto para contribuir, crescer junto ao time e entregar código limpo e performático! 🚀

---

> **Nota:** Este projeto é destinado exclusivamente à avaliação técnica para o processo seletivo.
