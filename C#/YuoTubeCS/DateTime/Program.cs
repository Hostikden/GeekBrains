DateTime dateTime = new DateTime();
Console.WriteLine(dateTime);

DateTime now = DateTime.Now;           //теперяшняя дата
System.Console.WriteLine(now.ToString());

System.Console.WriteLine($"It's {now.Date}, {now.Hour}ч. : {now.Minute}мин.");

DateTime dt = new DateTime(2016, 2, 28); //конструируем свою дату
System.Console.WriteLine(dt);

//DateTime имеет арифметику на датах

DateTime newDt = dt.AddDays(2); //добавляем 2 дня
System.Console.WriteLine(newDt);

//Арифметика на датах очень сложна

TimeSpan newDt2 = newDt.Subtract(now); //отнимаем через TimeSpan

//более красивая запись:
// TimeSpan newDt2 = newDt2 - now;

System.Console.WriteLine(newDt2.TotalDays); // TotalDays в отличии от Days 
//возвращает дабл, тк при вычтании возвращает точное количество дней

