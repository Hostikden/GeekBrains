// Console.WriteLine ("Введите координату X: ");
// int x = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine ("Введите координату Y: ");
// int y = Convert.ToInt32 (Console.ReadLine());

// if (x == 0 || y == 0)
// {
//     Console.WriteLine("Не видно четверти...");
// }

// else if (x > 0 && y > 0) {
//     Console.WriteLine ("1-ая четверть");
// }
// else if (x < 0 && y > 0) {
//     Console.WriteLine ("2-ая четверть");
// }
// else if (x < 0 && y < 0) {
//     Console.WriteLine ("3-ая четверть");
// }
// else if (x > 0 && y < 0) {
//     Console.WriteLine ("4-ая четверть");
// }


// Example 2:

void Show (int x, int y) {

if (x == 0 || y == 0)
{
    Console.WriteLine("Не видно четверти...");
}

else if (x > 0 && y > 0) {
    Console.WriteLine ("1-ая четверть");
}
else if (x < 0 && y > 0) {
    Console.WriteLine ("2-ая четверть");
}
else if (x < 0 && y < 0) {
    Console.WriteLine ("3-ая четверть");
}
else if (x > 0 && y < 0) {
    Console.WriteLine ("4-ая четверть");
}
}


// Console.WriteLine ("Введите координату X: ");
// int x2 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine ("Введите координату Y: ");
// int y2 = Convert.ToInt32 (Console.ReadLine());

Show(5, 10);
Show(5, -10);
Show(5, 0);
// Show(x2, y2);