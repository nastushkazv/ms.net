# ms.net
Требования к приложению Турагентство
1. Функциональные требования
   
1.1. Регистрация пользователя
Пользователь должен иметь возможность зарегистрироваться в системе, указав:
Имя пользователя
Пароль
Электронный адрес
Дополнительные поля по усмотрению (например, телефон, дата рождения).
При регистрации пароль должен быть подтвержден.
Система должна проверять уникальность имени пользователя и адреса электронной почты.
При успешной регистрации пользователю необходимо выслать письмо с подтверждением регистрации.

1.2. Вход (Login) и Выход (Logout)
Пользователь должен иметь возможность войти в систему, используя имя пользователя и пароль.
Система должна проверять правильность введенных данных.
При успешном входе пользователь должен быть перенаправлен на главную страницу приложения.
Пользователь должен иметь возможность выйти из системы, после чего он будет перенаправлен на страницу входа.

1.3. Просмотр списка записей (INDEX)
Пользователь должен иметь возможность просматривать список доступных туров.
Список должен быть отсортирован по дате, цене, направлению, типу тура или другим критериям.
Список должен содержать следующую информацию о каждом туре:
Название тура
Направление
Дата начала и окончания тура
Тип тура (отдых, экскурсия, круиз, и т.д.)
Цена
Дополнительные сведения по усмотрению (фото, описание тура, количество мест, и т.д.)

1.4. Создание записи (CREATE)
Пользователь должен иметь возможность создавать новую запись о туре.
Система должна предоставлять возможность ввести следующую информацию о туре:
Название тура
Направление
Дата начала и окончания тура
Тип тура
Цена
Дополнительные сведения по усмотрению
Система должна проверять правильность введенных данных.
После успешного создания записи о туре, она должна быть добавлена в список доступных туров.

1.5. Просмотр деталей записи (READ)
Пользователь должен иметь возможность просмотреть подробную информацию о выбранном туре.
Детальная информация о туре должна содержать:
Все сведения, указанные в списке доступных туров.
Дополнительные сведения о туре, такие как:
Программа тура
Описание отелей
Фотографии
Отзывы других пользователей
Дополнительные услуги (экскурсии, трансферы, и т.д.)

1.6. Редактирование записи (UPDATE)
Пользователь должен иметь возможность редактировать информацию о туре.
Система должна предоставлять возможность изменения:
Названия тура
Направления
Даты начала и окончания тура
Типа тура
Цены
Дополнительных сведений по усмотрению
Система должна проверять правильность введенных данных.
После успешного редактирования записи, информация о туре в списке доступных туров должна быть обновлена.

1.7. Удаление записи (DELETE)
Пользователь должен иметь возможность удалять запись о туре из системы.
Система должна запрашивать подтверждение удаления записи.
После успешного удаления запись должна быть удалена из списка доступных туров.

База Данных
![Модель туристического агентства]([file:///C:/Users/User/Desktop/МОиАИС,ПММ/3КУРС/5СЕМ/MS.NET/turag.jpg](https://github.com/nastushkazv/ms.net/blob/main/turag.pdf))
