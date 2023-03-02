# БАЗЫ ДАННЫХ

## Урок 1

**СУБД** - (инструмент) система управления базами данных.

Базы данных необходимы для хранения, обработки и быстрого извлечения необходимой информации.

### Иерархическая модель

**Иерархическая модель** хранения данных.

При создании иеархической модели бд мы изначально фиксируем сценарий использование бд.

Есть решение данной проблемы - предметный указатель.

Важно добавление **уникальных индификаторов** и связывание таблиц между собой именно по этому индификатору (первичный ключ). Запись в связанной таблице по первичному ключу - внешний ключ (иначе ссылка на первыичный ключ).

### Реалиционные бд

Relation - связь.

**Реляционные базы данных** - это базы данных, в которых данные распределены по отдельным, связанны между собой, таблицам.


Как быстро начать в бд

https://telegra.ph/Kak-nachat-v-SQLite-09-06


Прочитать историю про медведей картины мишки в лесу.


## Урок 2

Из таблиц можно **выбрать** необходимые столбцы.

**SQL** - особый язык программирования, который позволяет формулировать то, что необходимо сделать с данными в таблицах.

Пример:

``` SELECT * FROM Общий список ```

``` 
SELECT - выбери
* - все данные
FROM - из
Общий список - название таблицы

```

SQL JOIN на примере POSTGRESQL 14.4

https://github.com/iksergey/Hobby/blob/master/SQL_JOIN/SQL_Join.pdf

## Типы соединения таблиц:

**INNER JOIN**

**LEFT JOIN** 

**RIGHT JOIN**

**FULL JOIN**