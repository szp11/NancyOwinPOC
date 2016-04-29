# NancyOwinPOC

#### Portuguese:

Proof-Of-Concept (Prova de conceito) de implementação de um webservice em C# leve (Nancy), utilizando Self-hosting (OWIN) e funcionando como serviço (TopShelf) para testes de intercâmbio de plataformas (Windows/Linux - usando Mono). Será considerado também o uso do Docker para hospedagem.

Este projeto tem como premissa utilizar tecnologias multiplataformas, então o banco de dados à ser considerado aqui será o PostgreSQL e o driver Npgsql.

#### English:

This project is a Proof-of-concept of a C# multi-platform lightweight webservice implementation, considering the following technologies and frameworks: Nancy (lightweight, low-ceremony framework), OWIN (Self-hosting), TopShelf (Service-ease) and Mono. I'll consider using Docker as a hosting option (when using Linux) and PostgreSQL (with Npgsql) for the database bits.


### Objetivos do projeto (Project goals):
 - Multiplataforma (Multi-platform);
 - Rodar como serviço (tanto no Windows quanto no Linux) (Run as a Service (both Windows and Linux));
 - C# (Mono - Linux/.NET framework - Windows);
 - Prover uma API com OAuth - Autenticação/Autorização via token (Provide an API with Token-based OAuth authentication/authorization);
 - Prover uma aplicação básica MVC usando autenticação por Cookie com Razor views, ou outra engine de telas (Provide a basic Cookie-auth MVC App with Razor views or another engine);
 - Ambas as aplicações (API e MVC) devem compartilhar as mesmas regras de negócio (both apps (API and MVC) MUST share the same business rules);
 - Futura extensão para SSO (Single Sign-On) (Future SSO extention);

Este projeto foi baseado no artigo http://bytefish.de/blog/token_authentication_owin_nancy/
