﻿/*
Методы, которые что-то возвращают, но ничего не принимают

1. обязательно указываем тип данных
*/

int Method3()
{
    return DateTime.Now.Year;     // производим какую-то работу
}

int year = Method3();             // в year кладём результат работы метода
System.Console.WriteLine(year);   // выводим переменную