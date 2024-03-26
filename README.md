# EmitEasy Emissão de Nota de Serviço

Está sendo desenvolvido um sistema utilizando arquitetura de microsserviços, implementando funcionalidades relacionadas a cadastro empresa, cadastro clientes, emissão de NFSe e envio para prefeitura atraves de mensageria.


## Tecnologias e práticas utilizadas
- ASP.NET Core com .NET 7
- Sql-Server
- Swagger
- Injeção de Dependência
- Padrão Repository
- Mensageria com RabbitMQ

## Funcionalidades
- CRUD Empresa
- CRUD Clientes
- CRUD NFSe
- Envio pacote Nfse

Obs.
O consumo da mensagem é realizado na API-NFSESantos.
O envio para prefeitura é realizado utilizando protocolo SOAP, com autenticação e assinatura do xml usando certificado digital modelo A1.

