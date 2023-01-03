// Задача 15:
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//Example 1:

Console.WriteLine("Введите цифру обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void ChekingTheDayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine($"{dayNumber} -> да");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine($"{dayNumber} -> это не день недели =(");
    }

    else if (dayNumber > 0 && dayNumber < 6)
    {
        Console.WriteLine($"{dayNumber} -> нет");
    }

}

ChekingTheDayOfTheWeek(dayNumber);


// Example 2:

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         int number = EnterNumber("Введите одно целое число");
//         ShowWeekend(number);
//     }

//     static int EnterNumber(string str)
//     {
//         System.Console.WriteLine(str);
//         string stringNumber = Console.ReadLine()!.Trim();
//         int number;
//         while (!int.TryParse(stringNumber, out number))
//         {
//             Console.WriteLine("Ошибка! Введите одно целое число");
//             stringNumber = Console.ReadLine()!.Trim();
//         }
//         return number;
//     }
//     static void ShowWeekend(int i)
//     {
//         switch (i)
//         {
//             case > 0 and <= 5:
//                 Console.WriteLine($"{i} -> нет");
//                 break;

//             case 6:
//             case 7:
//                 Console.WriteLine($"{i} -> да");
//                 break;
//             default:
//                 Console.WriteLine($"{i} -> не день недели");
//                 break;
//         }
//     }
// }
