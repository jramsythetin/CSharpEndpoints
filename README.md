# ToDoList API

Este projeto é uma API RESTful em C# para gerenciamento de tarefas (ToDo List).  

Ele foi desenvolvido como estudo de **endpoints**, **arquitetura de software** e **padrão MVC**. O objetivo é aplicar conceitos de **Clean Architecture**, separando os casos de uso da camada de apresentação (Controllers)

---

## Tecnologias utilizadas

- **C# 12**
- **.NET 8.0.4**
- **ASP.NET Core Web API**
- **Padrão MVC**
- **Clean Architecture (Use Cases)**

---

## Estrutura do Projeto

- **Controllers:** Contém os endpoints da API.  
- **Application/UseCases/Task:** Implementa os casos de uso (CRUD).  
- **Communication/Requests:** Objetos de requisição.  
- **Communication/Responses:** Objetos de resposta.

---

## Endpoints

| Método | Endpoint         | Descrição                       | Resposta |
|--------|----------------|---------------------------------|----------|
| POST   | `/api/item`     | Cadastrar uma nova tarefa        | 201 Created / 400 BadRequest |
| PUT    | `/api/item/{id}`| Atualizar tarefa existente       | 204 NoContent / 400 BadRequest |
| GET    | `/api/item`     | Retornar todas as tarefas       | 200 OK / 204 NoContent |
| GET    | `/api/item/{id}`| Retornar tarefa por ID           | 200 OK / 404 NotFound |
| DELETE | `/api/item/{id}`| Deletar tarefa por ID            | 204 NoContent / 404 NotFound |

---

## Objetivo do estudo

Este projeto foi criado para:

1. Praticar a criação de **endpoints RESTful**.
2. Implementar **padrão MVC** em C#.
3. Aplicar **Clean Architecture** em pequenos casos de uso.
4. Organizar o código separando **camadas de comunicação, aplicação e domínio**.

---

## Como rodar

1. Clone o repositório:
```bash
git clone https://github.com/jramsythetin/CSharpEndpoints.git
