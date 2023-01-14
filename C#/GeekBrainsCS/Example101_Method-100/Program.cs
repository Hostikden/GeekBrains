// Пример метода на задаче 100

int Max(int id1, int id2, int id3)
{
    int result = id1;
    if (id2 > result) result = id2;
    if (id3 > result) result = id3;
    return result;

}

int a1 = 15;
int b1 = 21;
int c1 = 39;

int a2 = 12;
int b2 = 2311;
int c2 = 33;

int a3 = 13;
int b3 = 23;
int c3 = 313;

int max1 = Max (a1, b1, c1);      // можем заменить
int max2 = Max (a2, b2, c2);      // на комментарии
int max3 = Max (a3, b3, c3);      // ниже
int max = Max (max1, max2, max3); // !!!!!!!

// int max = Max(
//     Max (a1, b1, c1),
//     Max (a2, b2, c2),
//     Max (a3, b3, c3));


Console.WriteLine(max);