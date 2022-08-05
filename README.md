# MailController 0.2a

Библиотека для облегчения работы с .NET (System.Net.Mail)

Тз - создание обратной связи для пользователя приложения, последствием отправки на почту сообщения 

(без внятного тз - результат хз)

```cs

class MailController

```

- конструкторы

```cs

public MailController(string emailAdress, string password, string name)

```


emailAdress - адресс электронной почты для приема и отпраки сообщения
password - пароль для входа в аккаунт гугл (рекомендуется создать пароль для приложения в Google(Настройки аккаунта -> Безопастность -> Вход в аккаунт Google))
name - Имя(заголовок), которое будет напечатано как название письма
![image](https://user-images.githubusercontent.com/78916980/178056878-e65f16fe-d0ee-4cab-a881-f99a90877f80.png)



- методы


```cs

string receiver, string message, string subject

```

Отправка сообщения message c заголовком subject на эл. адрес receiver
