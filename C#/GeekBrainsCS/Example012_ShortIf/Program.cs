//вводим рандомное двухзначное
//выбираем наибольшее из двух цифр числа

int number = new Random().Next(10, 100);
System.Console.WriteLine(number);

// if (number / 10 > number % 10)
// {
//     System.Console.WriteLine(number / 10);
// }
// else
// {
//     System.Console.WriteLine(number % 10);
// }

System.Console.WriteLine("через краткий if");
System.Console.WriteLine(number / 10 > number % 10 ?
                         number / 10 :
                         number % 10);