/////////////////////////  Поиск  //////////////////////////

int[] myArray = { 10, 2, 1, 4, 5, 6, 2, 1, 90 };

int result = Array.Find(myArray, i => i < 10);

System.Console.WriteLine(result);

////////////////////////////////////////////////////////////

int[] result2 = Array.FindAll(myArray, i => i < 10);

for (int i = 0; i < result2.Length; i++)
{
    System.Console.Write($"{result2[i]}\t");

}

System.Console.WriteLine();
