# CSharpMicroservices

![image](https://github.com/AmirNotch/CSharpMicroservices/assets/69799846/b6c4f012-bcf5-40f7-adeb-843891206014)

Реализация микросервисов на платформе .Net, которая использует Asp.Net Web API, Docker, RabbitMQ, MassTransit, gRPC, Ocelot API Gateway, MongoDB, Redis, PostgreSQL, SQL Server, Dapper, Entity Framework Core, реализацию CQRS и чистую архитектуру. 
Также включает в себя обработку пересекающихся аспектов, таких как реализация централизованного распределенного логирования с использованием Elasticsearch и Kibana.

Для этой работы вам понадобятся следующие инструменты:

- Visual Studio 2019-2022.
- .Net 6 SDK.
- Docker Desktop.

В этом репозитории включены следующие функции:

Catalog микросервисов, который включает:

Приложение ASP.NET Core Web API
Принципы REST API и операции CRUD
Подключение и контейнеризация базы данных MongoDB
Реализация шаблона репозитория
Внедрение Swagger Open API

Микросервис Basket, который включает:

Приложение ASP.NET Web API
Принципы REST API и операции CRUD
Подключение и контейнеризация базы данных Redis
Использование сервиса Grpc для межсервисного взаимодействия для расчета конечной цены продукта
Публикация очереди BasketCheckout с использованием MassTransit и RabbitMQ

Микросервис Discount, который включает:
Приложение ASP.NET Grpc Server
Высокопроизводительное межсервисное взаимодействие с микросервисом корзины с использованием Grpc
Предоставление Grpc-сервисов с созданием сообщений Protobuf
Использование Dapper для реализации микро-ORM для упрощения доступа к данным и обеспечения высокой производительности
Подключение и контейнеризация базы данных PostgreSQL

Взаимодействие между микросервисами:
Синхронное межсервисное взаимодействие с использованием Grpc
Асинхронное межсервисное взаимодействие с использованием сообщений RabbitMQ
Использование модели обмена Publish/Subscribe с RabbitMQ
Использование MassTransit для абстракции над системой сообщений RabbitMQ
Публикация события BasketCheckout из микросервиса корзины и подписка на это событие из микросервиса заказа

Ordering микросервис:
Реализация DDD, CQRS и Clean Architecture с использованием лучших практик
Разработка CQRS с использованием пакетов MediatR, FluentValidation и AutoMapper
Получение сообщений очереди BasketCheckout из RabbitMQ с использованием конфигурации MassTransit-RabbitMQ
Подключение к базе данных SqlServer и ее контейнеризация
Использование ORM Entity Framework Core и автоматическое мигрирование на SqlServer при запуске приложения

Микросервис API Gateway Ocelot:
Реализация API Gateway с использованием Ocelot
Образцы микросервисов и контейнеров для перенаправления через API Gateway
Запуск разных типов контейнеров API Gateway/BFF
Шаблон агрегации Gateway в Shopping.Aggregator

Микросервис веб-приложения ShoppingApp:
ASP.NET Core веб-приложение с Bootstrap 4 и шаблоном Razor
Вызов API с помощью HttpClientFactory и Polly

Пересекающиеся реализации микросервисов:
Централизованное распределенное логирование с использованием Elastic Stack (ELK): Elasticsearch, Logstash, Kibana и SeriLog для микросервисов
Использование функции HealthChecks в бэк-энд микросервисах ASP.NET
Использование службы Watchdog в отдельном сервисе, который может следить за состоянием и нагрузкой микросервисов и предоставлять информацию о состоянии микросервисов, запросив HealthChecks

Реализация устойчивости микросервисов:
Использование IHttpClientFactory для реализации устойчивых HTTP-запросов
Реализация шаблонов Retry и Circuit Breaker с экспоненциальной задержкой с использованием IHttpClientFactory и политик Polly

Вспомогательные контейнеры-Docker:
Использование Portainer для управления контейнерами с удобным интерфейсом
Использование pgAdmin PostgreSQL Tools для администрирования и разработки PostgreSQL
Настройка Docker Compose со всеми микросервисами в Docker, включая контейнеризацию микросервисов и баз данных, а также переопределение переменных среды.

![image](https://github.com/AmirNotch/CSharpMicroservices/assets/69799846/976e5eca-f818-4c8f-81c5-e20fc9528f7d)

Мой LinkedIn - https://www.linkedin.com/in/amir-ibragimov-7139b515b/
