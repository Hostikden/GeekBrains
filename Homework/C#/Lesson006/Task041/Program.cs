/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();
System.Console.WriteLine($"\nВведите желаемое кол-во цифр:\t");
int count = int.Parse(Console.ReadLine());

int[] myArray = new int[count];
for (int i = 0; i < myArray.Length; i++)
{
    System.Console.Write($"Введите число № {i + 1}:\t");
    myArray[i] = int.Parse(Console.ReadLine());
}

PrintMyArray(myArray);
System.Console.Write(" -> ");
Positive(myArray);

void PrintMyArray(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
}

void Positive(int[] coll)
{
    int count = 0;
    for (int index = 0; index < coll.Length; index++)
    {
        if (coll[index] > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine(count);
}
