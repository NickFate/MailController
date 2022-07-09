# MailController 0.2a

Библиотека для облегчения работы с .NET (System.Net.Mail)

Тз - создание обратной связи для пользователя приложения, последствием отправки на почту сообщения 

(без внятного тз - результат хз)

```cs

class MailController

```

- конструкторы

```cs

public MailController(string emailAdress, string password)

```

emailAdress - адресс электронной почты для приема и отпраки сообщения
password - пароль для входа в аккаунт гугл (рекомендуется создать пароль для приложения в Google(Настройки аккаунта -> Безопастность -> Вход в аккаунт Google))
![image](https://user-images.githubusercontent.com/78916980/178056878-e65f16fe-d0ee-4cab-a881-f99a90877f80.png)

```cs

public MailController(string emailAdress, string password, string name)

```

name - Имя(заголовок), которое будет напечатано как название письма

- методы


```cs

public void SendMessage(string message)

```
Метод отправляет письмо с телом письма message


```cs

public void SendMessage(string message, string subject)

```

Метод отправляет письмо с заголовком subject и телом письма message
