// ввводим массив, для того что бы избавиться от количества переменных
// на примере 101 задачи

int Max(int id1, int id2, int id3)
{
    int result = id1;
    if (id2 > result) result = id2;
    if (id3 > result) result = id3;
    return result;

}

//               0   1   2   3   4   5   6   7   8
int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 };
array[0] = 12;

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
System.Console.WriteLine(result);