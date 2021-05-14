# Nerd Store Enterprise

Este projeto foi desenvolvido com base nos ensinamentos do curso "ASP.NET Core Enterprise Applications" do professor Eduardo Pires - desenvolvedor.io

O projeto é uma aplicação de e-commerce feita de maneira distribuída em várias APIs utilizando comunicação via filas com o RabbitMQ.

Este projeto faz o uso de:
- Conceitos do DDD
- Comunicação por filas
- APIs Gateway
- Load balancer
- SSL
- JWT
- GRPC
- RabbitMQ
- Docker
- Nginx
- SQL Server

## Como executar
 O projeto roda em containers Docker e um arquivo .yml já está configurado para ser executado com o docker-compose! Então basta navegar até a pasta `NerdStoreEnterprise\docker` e executar o comando: 
```docker-compose
docker-compose -f nerdstore_producao.yml up
```

O projeto está preparado para rodar em Load Balancing e com o comando abaixo você executa o projeto com quatro instâncias do web app MVC.
```docker-compose
docker-compose -f nerdstore_producao.yml up --scale web-mvc=4
```

![Layout - home](https://user-images.githubusercontent.com/40338966/106770048-59676d80-661c-11eb-89d5-ab8249ababfc.jpg)

![Final](https://user-images.githubusercontent.com/40338966/106770133-6a17e380-661c-11eb-99be-904cdb1d1829.jpg)
