# ms.net
Требования к приложению Турагентство  

1. Роли  

1.1 Пользователь  
Человек, который ищет информацию о турах и может бронировать их.  
1.2 Сотрудник  
Сотрудник, который управляет турами, может редактировать, добавлять и удалять информацию о них.  

2. Функциональные требования

Пользователь:  
   
2.1. Регистрация пользователя  
Пользователь должен иметь возможность зарегистрироваться в системе, указав:  
Имя пользователя  
Пароль  
Электронный адрес  
Дополнительные поля по усмотрению (например, телефон, дата рождения).  
При регистрации пароль должен быть подтвержден.  
Система должна проверять уникальность имени пользователя и адреса электронной почты.  
При успешной регистрации пользователю необходимо выслать письмо с подтверждением регистрации.  

2.2. Вход (Login) и Выход (Logout)  
Пользователь должен иметь возможность войти в систему, используя имя пользователя и пароль.  
Система должна проверять правильность введенных данных.  
При успешном входе пользователь должен быть перенаправлен на главную страницу приложения.  
Пользователь должен иметь возможность выйти из системы, после чего он будет перенаправлен на страницу входа.  

2.3. Просмотр списка записей (INDEX)  
Пользователь должен иметь возможность просматривать список доступных туров.  
Список должен быть отсортирован по дате, цене, направлению, типу тура или другим критериям.  
Список должен содержать следующую информацию о каждом туре:  
Название тура  
Направление  
Дата начала и окончания тура  
Тип тура (отдых, экскурсия, круиз, и т.д.)  
Цена  
Дополнительные сведения по усмотрению (фото, описание тура, количество мест, и т.д.)  

2.4. Создание записи (CREATE)  
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

2.5. Просмотр деталей записи (READ)  
Пользователь должен иметь возможность просмотреть подробную информацию о выбранном туре.  
Детальная информация о туре должна содержать:  
Все сведения, указанные в списке доступных туров.  
Дополнительные сведения о туре, такие как:  
Программа тура  
Описание отелей  
Фотографии  
Отзывы других пользователей  
Дополнительные услуги (экскурсии, трансферы, и т.д.)  

2.6. Редактирование записи (UPDATE)  
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

2.7. Удаление записи (DELETE)  
Пользователь должен иметь возможность удалять запись о туре из системы.  
Система должна запрашивать подтверждение удаления записи.  
После успешного удаления запись должна быть удалена из списка доступных туров.  

 Cотрудник:  
 
3.1. Регистрация сотрудника  
Регистрация пользователя не требуется. Работники могут быть добавлены через административный интерфейс.  

3.2. Вход (Login) и Выход (Logout)  
Доступно для всех работников.  

3.3. Просмотр списка записей (INDEX)  
Возможность просмотра всех доступных туров без ограничений.  

3.4. Создание записи (CREATE)    
Возможность создания новой записи о туре с вводом всех необходимых данных.  
Проверка правильности введенных данных.  
Добавление записи в список доступных туров после успешного создания.  

3.5. Просмотр деталей записи (READ)  
Доступно для всех работников.  

3.6. Редактирование записи (UPDATE)  
Возможность редактирования информации о туре.  
Изменение всех необходимых данных (название, направление, даты, тип, цена и т.д.).  
Проверка правильности введенных данных.  
Обновление информации в списке доступных туров после успешного редактирования.  

3.7. Удаление записи (DELETE)  
Возможность удаления записи о туре из системы.  
Запрос подтверждения удаления записи.  
Удаление записи из списка доступных туров после успешного удаления.   

База Данных  
![Модель туристического агентства]([file:///C:/Users/User/Desktop/МОиАИС,ПММ/3КУРС/5СЕМ/MS.NET/1lab/turag data base/turag.jpg](https://github.com/nastushkazv/ms.net/blob/main/turag%20data%20base.pdf))
