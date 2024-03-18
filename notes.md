# команды

* dotnet new console
* git init
* dotnet new gitignore
* git add .
* git commit -m "init"
* dotnet add package System.Data.SQLite
* dotnet add package Telegram.Bot
* dotnet add package Dapper
* git remote add origin https://gitverse.ru/sc/atrusov/tgbot2024.git
* git branch -M master
* git push -u origin master
* dotnet add package Microsoft.Extensions.Configuration
* dotnet add package Microsoft.Extensions.Hosting
* dotnet add package Microsoft.Extensions.Logging

# Базы данных

1) Пароль не хранят в открытом виде
2) В разных сценариях нужны разные модели (с паролем при добавлении нового пользователя или без пароля при получении списка)
3) Entity - "сырая" модель с теми же полями, что и колонки в соотвествующей таблице
4) Model - "обработанная" модель под конкретную задачу
5) Services - функции чтения/записи в БД

# ссылки

* https://github.com/TelegramBots/Telegram.Bot
* https://www.connectionstrings.com/
* https://learn.microsoft.com/ru-ru/dotnet/core/extensions/configuration
